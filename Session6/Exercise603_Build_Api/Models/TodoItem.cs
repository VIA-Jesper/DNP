using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercise603_Build_Api.Models
{
    public class TodoItem
    {
        [Required]
        public long Id { get; set; }
        [StringLength(999, ErrorMessage = "Length must be higher than 3 chars", MinimumLength = 3)]
        public string Name { get; set; }


        public string Description { get; set; }
        public bool IsComplete { get; set; }

    }
}
