using Crud_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_MVC.Data
{
    public class Banco : DbContext
    {
        public Banco(DbContextOptions<Banco> options) : base(options)
        {   }
        public DbSet<RepositoriosModel> RepositoriosModels { set; get; }
    }
}
