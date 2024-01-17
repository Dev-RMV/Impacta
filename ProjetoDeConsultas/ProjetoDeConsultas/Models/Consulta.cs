using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDeConsultas.Models
{
    public class Consulta
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Medico { get; set; }//a pegar da tabela Medico
        [Required]
        [DisplayName("Paciente")]
        public string Cliente { get; set; }//a pegar da tabela Cliente
        [Required]
        public string Horario { get; set; } //a pegar da tabela horarios

    }
}
