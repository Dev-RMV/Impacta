using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula05.Models;

namespace Aula05.Data
{
    public class Aula05Context : DbContext
    {
        public Aula05Context (DbContextOptions<Aula05Context> options)
            : base(options)
        {
        }

        public DbSet<Aula05.Models.Movie> Movie { get; set; } = default!;
    }
}
