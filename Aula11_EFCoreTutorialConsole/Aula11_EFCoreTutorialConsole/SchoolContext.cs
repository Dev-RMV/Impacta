using Microsoft.EntityFrameworkCore;


namespace Aula11_EFCoreTutorialConsole
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(Localdb)\\mssqlLocaldb;DataBase=SchoolDb;Trusted_Connection=True;");
        }
    }
}
