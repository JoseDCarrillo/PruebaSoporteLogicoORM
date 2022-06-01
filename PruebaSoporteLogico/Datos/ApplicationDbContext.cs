using Microsoft.EntityFrameworkCore;
using PruebaSoporteLogico.Models;

namespace PruebaSoporteLogico.Datos
{
    public class ApplicationDbContext : DbContext
    {
        //Contructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .HasMany<Vinculacion>(e => e.vinculacions)
                .WithOne(v => v.Empleado)
                .HasForeignKey(v => v.IdEmpleado_Vinculacion);


        }
            //Modelos
            public DbSet<Empleado> Empleado { get; set; }
            public DbSet<Vinculacion> Vinculacion { get; set; }

    }
}
