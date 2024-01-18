using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula13_ControleAutomoveis.Models;

namespace Aula13_ControleAutomoveis.Data
{
    public class Aula13_ControleAutomoveisContext : DbContext
    {
        public Aula13_ControleAutomoveisContext (DbContextOptions<Aula13_ControleAutomoveisContext> options)
            : base(options)
        {
        }

        public DbSet<Aula13_ControleAutomoveis.Models.Proprietario> Proprietario { get; set; } = default!;

        public DbSet<Aula13_ControleAutomoveis.Models.Veiculo>? Veiculo { get; set; }
    }
}
