using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDeConsultas.Models
{
    public class Medico
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required]
        [DisplayName("CRM")]
        public string Crm { get; set;}
        [Required]
        public string? Especialidade { get; set; }//a pegar da tabela Especialidade
        public string? Horarios {  get; set; } //a pegar da tabela Horarios
    }
}
