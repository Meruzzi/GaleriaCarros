using System.ComponentModel.DataAnnotations;

namespace GaleriaCarros.Models
{
    public class Usuario
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email incorreto")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }
    }
}
