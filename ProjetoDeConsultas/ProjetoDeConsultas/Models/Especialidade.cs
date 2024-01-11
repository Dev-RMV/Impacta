using System.ComponentModel.DataAnnotations;

namespace ProjetoDeConsultas.Models
{
    public class Especialidade
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }      

    }
}
