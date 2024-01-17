using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDeConsultas.Models
{
    public class Exame
    {
        [Required]
        public int ExameId { get; set; }
        [Required]
        [DisplayName("Nome")]
        public string NomeExame { get; set;}
        [Required]
        [DisplayName("Descrição")]
        public string Descricao { get; set;}
    }
}
