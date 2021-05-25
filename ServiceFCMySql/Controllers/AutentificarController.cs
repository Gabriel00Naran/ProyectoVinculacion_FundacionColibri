using WebServiceFCMySql.Autenticacion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceFCMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutentificarController : ControllerBase
    {
        private readonly UserManager<AplicacionUsuario> usuarioManager;

        private readonly IConfiguration _configuration;

        public AutentificarController
           (
           UserManager<AplicacionUsuario> usuarioManager,
                IConfiguration configuration
           )
        {
            this.usuarioManager = usuarioManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModelo modelo)
        {
            var user = await usuarioManager.FindByNameAsync(modelo.Username);
            if (user != null && await usuarioManager.CheckPasswordAsync(user, modelo.Password))
            {

                var autenticarClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: autenticarClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("registro-Usuario")]
        public async Task<IActionResult> Registro_Usuario([FromBody] RegistroModelo modelo)
        {
            var userExists = await usuarioManager.FindByNameAsync(modelo.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Respuesta { Estado = "Error", Mensaje = "el usuario ya existe!" });

            AplicacionUsuario user = new()
            {
                Email = modelo.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = modelo.Username
            };
            var result = await usuarioManager.CreateAsync(user, modelo.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError,
                new Respuesta
                { Estado = "Error", Mensaje = "Error al crear el usuario, chechee los detalles he intentelo de nuevo." });

            return Ok(new Respuesta { Estado = "Success", Mensaje = "Usuario creado con exito!" });
        }
    }
}
