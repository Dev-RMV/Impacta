using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula19_SalesWebMvc.Models;

namespace Aula19_SalesWebMvc.Data
{
    public class Aula19_SalesWebMvcContext : DbContext
    {
        public Aula19_SalesWebMvcContext (DbContextOptions<Aula19_SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Aula19_SalesWebMvc.Models.Department> Department { get; set; } = default!;
        public DbSet<Seller> Sellers { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
    }
}
