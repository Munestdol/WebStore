using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreEverything.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid length")]

        public string Name { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid length")]
        public string Description { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Invalid length")]
        public string Category { get; set; }

        [Range(1,9999999, ErrorMessage = "Invalid length")]
        public decimal Price { get; set; }
    }
}