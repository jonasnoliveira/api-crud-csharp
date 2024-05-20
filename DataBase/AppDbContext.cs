using ApiCrud.Students;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.DataBase
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBaseStudents.db");
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.EnableSensitiveDataLogging(); // just development

            base.OnConfiguring(optionsBuilder);
        }
    }
}
