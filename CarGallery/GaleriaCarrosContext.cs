using GaleriaCarros.Mapping;
using GaleriaCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace GaleriaCarros
{
    public class GaleriaCarrosContext : DbContext
    {
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Carro> Carros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public GaleriaCarrosContext(DbContextOptions<GaleriaCarrosContext> options) 
            : base (options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FabricanteMapping());
            modelBuilder.ApplyConfiguration(new CarroMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}
