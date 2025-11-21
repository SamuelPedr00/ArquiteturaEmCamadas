

using Camada.DAL.Maps;
using Camada.Model;
using Microsoft.EntityFrameworkCore;

namespace Camada.DAL.Context
{
    public class CamadaContext : DbContext
    {
        public CamadaContext(DbContextOptions<CamadaContext> options) : base (options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMap());
        }
    }
}
