using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Efcore_ExampleWarehouse.Entities.example
{
    public class Location
    {
        public string Position { get; set; }

        [AllowNull]
        public Pallet Pallet { get; set; }

        [AllowNull]
        public Client Client { get; set; }

        
    }
}
