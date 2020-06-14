using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Efcore_ExampleWarehouse.Entities.example
{
    public class Pallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PalletId { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        [AllowNull]
        public string Content { get; set; }

        [AllowNull]
        public Client Client { get; set; }
        public Pallet()
        {

        }
    }
}
