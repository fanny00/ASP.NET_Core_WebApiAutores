using Microsoft.EntityFrameworkCore;
using WebApiAutore.Controllers.Entidades;

namespace WebApiAutore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Autor> Autores{ get; set; }
    }
}
