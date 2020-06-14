using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VolumeWebService.VolumeCalculator;

namespace VolumeWebService.Data
{
    public class VolumeContext : DbContext
    {
        public VolumeContext (DbContextOptions<VolumeContext> options)
            : base(options)
        {
        }

        public DbSet<VolumeWebService.VolumeCalculator.VolumeResult> VolumeResult { get; set; }
    }
}
