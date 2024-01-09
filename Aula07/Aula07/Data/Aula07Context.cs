using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula07.Models;

namespace Aula07.Data
{
    public class Aula07Context : DbContext
    {
        public Aula07Context (DbContextOptions<Aula07Context> options)
            : base(options)
        {
        }

        public DbSet<Aula07.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
