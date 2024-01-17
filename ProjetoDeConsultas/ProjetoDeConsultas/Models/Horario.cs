namespace ProjetoDeConsultas.Models
{
    public class Horario
    {
        //Pensar como colocar horários disponíveis
        //O objetivo é criar 1 lista de horários que podem estar disponiveis ou não
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
