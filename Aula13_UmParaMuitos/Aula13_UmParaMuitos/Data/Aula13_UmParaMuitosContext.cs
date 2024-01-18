using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula13_UmParaMuitos.Models;

namespace Aula13_UmParaMuitos.Data
{
    public class Aula13_UmParaMuitosContext : DbContext
    {
        public Aula13_UmParaMuitosContext (DbContextOptions<Aula13_UmParaMuitosContext> options)
            : base(options)
        {
        }

        public DbSet<Aula13_UmParaMuitos.Models.Student> Student { get; set; } = default!;
        public DbSet<Aula13_UmParaMuitos.Models.Grade> Grade { get; set; } = default!;
    }
}
