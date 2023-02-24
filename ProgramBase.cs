using Microsoft.EntityFrameworkCore;

namespace Crud_MVC
{
    public class ProgramBase
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SV8GPJ2\\SQLEXPRESS;Initial Catalog=StarterAppDB;Persist Security Info=True;User ID=sa;Password=Admin@1234");
            }
        }
    }
}