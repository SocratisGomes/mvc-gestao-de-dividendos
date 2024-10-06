using System.ComponentModel.DataAnnotations;

namespace mvc_gestao_de_dividendos.Models
{
    public class Ativo
    {
        [Key]
        public int id { get; set; }

        [Required (ErrorMessage = "Obrigatório informar o ticker!")]
        public string Ticker { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o segmento!")]
        public string Segmento { get; set; }
    }
}
