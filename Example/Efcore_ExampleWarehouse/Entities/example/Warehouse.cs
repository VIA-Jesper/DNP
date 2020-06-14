using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Efcore_ExampleWarehouse.Entities.example
{
    public class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WarehouseId { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public decimal UnitPrice { get; set; }

        [AllowNull]
        public ICollection<Location> Locations { get; set; }

        public Warehouse()
        {

        }
    }
}
