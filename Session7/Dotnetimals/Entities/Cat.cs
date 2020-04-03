using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Dotnetimals.Entities
{
    public class Cat
    {
        [Key]
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

    }
}
