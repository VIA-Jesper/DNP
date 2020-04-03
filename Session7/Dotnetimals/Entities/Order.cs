using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dotnetimals.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDatee { get; set; }
        public string OrderNumber { get; set; }
        public ICollection<Cat> Cats { get; set; }
    }
}