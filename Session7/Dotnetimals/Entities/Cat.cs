using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace Dotnetimals.Entities
{
    public class Cat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(20), MinLength(2)]
        public string Name { get; set; }

        [RegularExpression(@"^[^<>.,?;:'()!~%\-_@#/*""\s]+$")]
        public string Color { get; set; }

        [Required, AllowNull]
        [Range(0,100), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public DateTime Birthday { get; set; }
        public string FavoriteDish { get; set; }
        //public ICollection<OrderItem> Orders { get; set; }

    }
}
