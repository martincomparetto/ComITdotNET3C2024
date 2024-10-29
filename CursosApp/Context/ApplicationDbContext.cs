using ComIT.Comunes.Entities;
using CursosApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CursosApp.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Prueba> Pruebas { get; set; }
    }
}
