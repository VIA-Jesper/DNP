using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnetimals.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dotnetimals.Data
{
    public class CatContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderCats { get; set; }


        public CatContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Make as the primary key of the join table
            modelBuilder.Entity<OrderItem>()
                .HasKey(oc => new { oc.OrderId, oc.CatId });

        }
    }
}
