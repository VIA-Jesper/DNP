using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Dotnetimals.Entities
{
    public class Order
    {
        [Key] // Force primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // makes sure ID is not set during creation.
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public ICollection<OrderItem> Cats { get; set; }
    }
}