using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WebServiceFC.Servicios;
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
{
    // remove formatter that turns nulls into 204 - No Content responses
    // this formatter breaks Angular's Http response JSON parsing
    opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
}
            ).AddNewtonsoftJson();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Servidor Datos Nido AFC", Version = "Version 1.0" });
            });

            ///INSTANCIAMOS LLA CONEXION DE LA BASE Y LOS SERVICIOS CREADOS 
            services.AddHttpClient();
            services.AddDbContext<fundacioncolibriContext>(options =>
            options.UseMySQL(Configuration.GetConnectionString("DatabaseConnection")));

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

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
