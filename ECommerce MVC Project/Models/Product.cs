using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ECommerce_MVC_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ImageName { get; set; }
    }
}
