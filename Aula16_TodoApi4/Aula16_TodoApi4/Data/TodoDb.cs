using Aula16_TodoApi4.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula16_TodoApi4.Data
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { } //construtor

        public DbSet<Todo> Todos =>Set<Todo>();
    }
}
