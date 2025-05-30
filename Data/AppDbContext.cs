using CrudMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVCApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Direccion> Direccion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Persona>()
                   .HasMany(p => p.Direcciones)
                   .WithOne(d => d.Persona)
                   .HasForeignKey(d => d.PersonaId);
        }

    }
}
