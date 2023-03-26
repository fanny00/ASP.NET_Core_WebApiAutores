using Microsoft.AspNetCore.Mvc;
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

        public static implicit operator ControllerContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
