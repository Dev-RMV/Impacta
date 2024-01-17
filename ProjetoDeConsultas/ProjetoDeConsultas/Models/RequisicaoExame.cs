namespace ProjetoDeConsultas.Models
{
    public class RequisicaoExame
    {
        public int RequisicaoExameId { get; set; }
        public string Cliente { get; set; }//a pegar da tabela Cliente
        public string Medico { get; set;}//a pegar da tabela Medico
        public string Exame { get; set;} //a pegar da tabela de Exames
    }
}
