using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Efcore_ExampleWarehouse.Entities.example
{
    public class Client
    {
        [Key]
        [NotNull]
        public string Username { get; set; }

        public string Name { get; set; }
    }
}
