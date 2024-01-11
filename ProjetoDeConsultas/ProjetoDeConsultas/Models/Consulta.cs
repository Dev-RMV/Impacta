using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDeConsultas.Models
{
    public class Consulta
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Medico { get; set; }
        [Required]
        [DisplayName("Paciente")]
        public string Cliente { get; set; }
        [Required]
        public DateTime Data { get; set; }

    }
}
