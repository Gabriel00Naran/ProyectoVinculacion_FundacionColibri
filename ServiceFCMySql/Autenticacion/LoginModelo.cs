using System.ComponentModel.DataAnnotations;

namespace WebServiceFCMySql.Autenticacion
{
    public class LoginModelo
    {
        [Required(ErrorMessage = "nombre de usuario requerido")]
        public string Username { get; set; }

        [Required(ErrorMessage = "password de usuario requerido")]
        public string Password { get; set; }
    }
}

