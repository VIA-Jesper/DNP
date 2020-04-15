using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dotnetimals.Entities
{
    // followed this guide: https://softdevpractice.com/blog/many-to-many-ef-core/
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        // one order should have many cats. 
        public int CatId { get; set; }
        public Cat Cat { get; set; }
    }
}
