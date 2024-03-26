using System.ComponentModel.DataAnnotations;

namespace GaleriaCarros.Models
{
    public class Carro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Descrição curta é obrigatório")]
        public string DescCurta { get; set; }
        [Required(ErrorMessage = "Descrição completa é obrigatório")]
        public string DescCompleta { get; set; }
        [Required(ErrorMessage = "Imagem é obrigatório")]
        public string Imagem { get; set; }
        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
