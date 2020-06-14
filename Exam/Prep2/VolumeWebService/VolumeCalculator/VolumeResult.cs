using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolumeWebService.VolumeCalculator
{
    public class VolumeResult
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Height { get; set; }
        public decimal Radius { get; set; }
        public double Volume { get; set; }
    }
}
