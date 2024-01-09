using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Aula07.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome do funcionário")]
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Data Admissão")]
        public DateTime DtAd { get; set; }
        
        public decimal Salario { get; set; }
    }
}
