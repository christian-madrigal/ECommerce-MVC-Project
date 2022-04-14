using System.Collections.Generic;

namespace ECommerce_MVC_Project.Models
{
    public class DBData : IData
    {
        public List<Product> Products { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int? id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> InitializeData()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
