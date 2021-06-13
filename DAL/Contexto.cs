using Microsoft.EntityFrameworkCore;
using RegistroConDetalle.Models;

namespace RegistroConDetalle.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Moras> Moras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Data\Prestamo.db");
        }
    }
}
