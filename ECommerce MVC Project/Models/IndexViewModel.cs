using System.Collections.Generic;
namespace ECommerce_MVC_Project.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<OrderDetails> OrderDetail { get; set; }
    }

    
}
