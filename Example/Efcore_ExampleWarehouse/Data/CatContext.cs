using Efcore_ExampleWarehouse.Entities.example;
using Microsoft.EntityFrameworkCore;

namespace Efcore_ExampleWarehouse.Data
{
    public class CatContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pallet> Pallets { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        public CatContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Make as the primary key of the join table
            modelBuilder.Entity<Location>().HasKey("WarehouseId", "Position");
        }
    }
}