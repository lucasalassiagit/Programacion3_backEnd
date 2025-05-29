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

    }
}
