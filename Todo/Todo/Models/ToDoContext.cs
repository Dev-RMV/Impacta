using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Todo.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
        public DbSet<ToDoItem> Items { get; set; }

    }
}

