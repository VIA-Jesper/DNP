using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dotnetimals.Entities
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        // one order should have many cats. 
        public int CatId { get; set; }
        public Cat Cat { get; set; }
    }
}
