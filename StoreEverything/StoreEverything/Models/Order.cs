using StoreEverything.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreEverything.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Invalid name length")]
        [Name]

        public string Name { get; set; }

        [Required(ErrorMessage = "You must provide at least one shipping address")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Invalid address length")]
        public string Line1 { get; set; }
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Invalid address length")]
        public string Line2 { get; set; }
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Invalid address length")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please indicate the city where you want to deliver the order")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Invalid city length")]
        [City]
        public string City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}