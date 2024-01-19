using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aula13_ControleAutomoveis.Models
{
    public class Proprietario
    {
        public int ProprietarioId { get; set; }
        public string Nome { get; set; }
        [DisplayName("CPF")]
        public string Cpf { get; set; }
        public string Veiculos { get; set;}
    }
}
