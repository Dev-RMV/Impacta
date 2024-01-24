using Microsoft.EntityFrameworkCore;

namespace Aula15_ToDo.Models
{
    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<ToDo> Todos => Set<ToDo>();
    }
}
