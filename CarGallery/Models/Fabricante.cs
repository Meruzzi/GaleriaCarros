using System.ComponentModel.DataAnnotations;

namespace GaleriaCarros.Models
{
    public class Fabricante
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nome é obrigatório")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        public String Descricao { get; set; }
        public List<Carro> Carros { get; set; } = new List<Carro>(); 
    }
}
