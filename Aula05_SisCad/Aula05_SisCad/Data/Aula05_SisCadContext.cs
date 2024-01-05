using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula05_SisCad.Models;

namespace Aula05_SisCad.Data
{
    public class Aula05_SisCadContext : DbContext
    {
        public Aula05_SisCadContext (DbContextOptions<Aula05_SisCadContext> options)
            : base(options)
        {
        }

        public DbSet<Aula05_SisCad.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<Aula05_SisCad.Models.Produtos>? Produtos { get; set; }
    }
}
