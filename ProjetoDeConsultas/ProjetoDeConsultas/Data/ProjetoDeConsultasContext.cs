using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoDeConsultas.Models;

namespace ProjetoDeConsultas.Data
{
    public class ProjetoDeConsultasContext : DbContext
    {
        public ProjetoDeConsultasContext (DbContextOptions<ProjetoDeConsultasContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoDeConsultas.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<ProjetoDeConsultas.Models.Especialidade>? Especialidade { get; set; }

        public DbSet<ProjetoDeConsultas.Models.Medico>? Medico { get; set; }

        public DbSet<ProjetoDeConsultas.Models.Consulta>? Consulta { get; set; }

        public DbSet<ProjetoDeConsultas.Models.Exame>? Exame { get; set; }

        public DbSet<ProjetoDeConsultas.Models.Horario>? Horario { get; set; }

        public DbSet<ProjetoDeConsultas.Models.RequisicaoExame>? RequisicaoExame { get; set; }
    }
}
