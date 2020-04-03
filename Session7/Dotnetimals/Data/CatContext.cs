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
        private DbSet<Order> Orders { get; set; }


        public CatContext(DbContextOptions options) : base(options)
        {

        }



    }
}
