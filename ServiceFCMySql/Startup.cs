using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;
using WebServiceFC.Servicios;
using WebServiceFCMySql.Autenticacion;
using WebServiceFCMySql.IServicios;
using WebServiceFCMySql.Modelos;
using WebServiceFCMySql.Servicios;

namespace WebServiceFC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers(
                opt =>  // or AddMvc()
{                   // remove formatter that turns nulls into 204 - No Content responses
                   // this formatter breaks Angular's Http response JSON parsing
                  opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
}            ).AddNewtonsoftJson();

            // AGREGAMOS EL SWAGGER MANUALMENTE PARA EVITAR ERRORES DE AUTENTIFICACION
            services.AddSwaggerGen(swagger =>
            {
                //This is to generate the Default UI of Swagger Documentation    
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v2",
                    Title = "WebService ACF Nido",
                    Description = "Autentificacion y Autorizacion in ASP.NET 5 con JWT y Swagger"
                });
                // To Enable authorization using Swagger (JWT)    
                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
                });
                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            Array.Empty<string>()

                    }
                });
            });

            services.AddHttpClient();

            ///INSTANCIAMOS LLA CONEXION DE LA BASE Y LOS SERVICIOS CREADOS 
            services.AddDbContext<fundacioncolibriContext>(options =>
            options.UseMySQL(Configuration.GetConnectionString("DatabaseConnection")));

            // PARA A�ADIR DATOS AL IdentitY
            services.AddIdentity<AplicacionUsuario, IdentityRole>()
                .AddEntityFrameworkStores<fundacioncolibriContext>()
                .AddDefaultTokenProviders();

            // A�ADIMOS LA AUTENTIFICACION 
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            // A�ADIMOS EL  JWT BEARER PARA PROBAR EL TOKEN GENERADO  
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["JWT:ValidAudience"],
                    ValidIssuer = Configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                };
            });



            /// AQUI LOS SERVICIOS
            services.AddTransient<IPersonaService, PersonaService>();
            services.AddTransient<ICantonService, CantonService>();
            services.AddTransient<ICasaAcogimientoService, CasaAcogimientoService>();
            services.AddTransient<IDatosSaludService, DatosSaludService>();
            services.AddTransient<IDatosJudicialPenalService, DatosJudicialPenalService>();
            services.AddTransient<IEstadoProcesalService, EstadoProcesalService>();
            services.AddTransient<IEtniaService, EtniaService>();
            services.AddTransient<IFamiliarReferenteService, FamiliarReferenteService>();
            services.AddTransient<IGeneroService, GeneroService>();
            services.AddTransient<IHistorialCronologicoService, HistorialCronologicoService>();
            services.AddTransient<IInfraccionDenunciadaService, InfraccionDenunciadaService>();
            services.AddTransient<IMedidaService, MedidaService>();
            services.AddTransient<IModalidadService, ModalidadService>();
            services.AddTransient<IMotivoIngresoService, MotivoIngresoService>();
            services.AddTransient<INacionalidadService, NacionalidadService>();
            services.AddTransient<INivelAcademicoService, NivelAcademicoService>();
            services.AddTransient<INudosCriticoService, NudosCriticoService>();
            services.AddTransient<IOrganizacionService, OrganizacionService>();
            services.AddTransient<IParroquiaService, ParroquiaService>();
            services.AddTransient<IPgfService, PgfService>();
            services.AddTransient<IProvinciaService, ProvinciaService>();
            services.AddTransient<IPersonaService, PersonaService>();


           //// A�ADIMOS LOS CORS PARA ENTRAR A LOS DATOS CON MAYOR SEGURIDAD
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });



        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebServiceFC v1"));
            }



            app.UseHttpsRedirection();

            app.UseRouting();

            //Aqui los cors
            app.UseCors("CorsPolicy");

            // agregamos la autorizacion.
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
