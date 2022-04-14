using System.Collections.Generic;
namespace ECommerce_MVC_Project.Models
{
    public interface IData
    {
        List<Product> Products { get; set; }
        IEnumerable<Product> InitializeData();
        Product GetProductById(int? id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int? id);

    }
}
