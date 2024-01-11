using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDeConsultas.Models
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [DisplayName("CPF")]
        public string Cpf { get; set; }
        [Required]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Idade { get => idade();  }

        public int idade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }
    }
}
