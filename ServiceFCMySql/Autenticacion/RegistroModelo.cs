using System.ComponentModel.DataAnnotations;

namespace WebServiceFCMySql.Autenticacion
{
    public class RegistroModelo
    {
        [Required(ErrorMessage = "Nombre y usuario Obligatorios")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email es obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password es obligatorio")]
        public string Password { get; set; }
    }
}
