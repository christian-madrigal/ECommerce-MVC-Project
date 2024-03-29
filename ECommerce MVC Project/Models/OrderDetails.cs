﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_MVC_Project.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [Display(Name = "Order")]
        public int OrderId { get; set; }
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        [Display(Name ="Customer")]
        public string UserId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("ProductId")]
        public Product Products { get; set; }
        [ForeignKey("UserId")]
        public Customer Customers { get; set; }

    }
}
