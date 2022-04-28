//using System.Collections.Generic;
//namespace ECommerce_MVC_Project.Models
//{
//    public class Data : IData
//    {
//        public List<Product> Products { get; set; }

//        public void AddProduct(Product product)
//        {
//            Products.Add(product);
//        }

//        public void DeleteProduct(int? id)
//        {
//            var prod = Products.Find(x => x.Id == id);
//            Products.Remove(prod);
//        }
//        public Data()
//        {
//            Products = new List<Product>()
//            {
//                new Product()
//                {
//                    Id =101,
//                    Name = "Jordan Retro 11",
//                    Description = "The Air Jordan 11 Cool Grey (2021) features a Cool Grey Durabuck upper with patent leather overlays and a signature Jumpman embroidery on the collar. ",
//                    Price= 190,
//                    ImageName="3.jpg"
//                },
//                new Product()
//                {
//                    Id =102,
//                    Name = "Yeezy Wave Runners",
//                    Description = "The Yeezy 700 Boost Wave Runner is the shoe that led Yeezy's pivot from a sleek, minimal aesthetic to a chunky, 90s inspired one. ",
//                    Price= 300,
//                    ImageName="4.jpg"
//                },
//                new Product()
//                {
//                    Id =103,
//                    Name = "Yeezy Ochre Foam RNNR",
//                    Description = "The adidas Yeezy Foam RNNR Ochre features a golden Ochre one-piece EVA foam construction. Oval cut-outs throughout the design provide ventilation, while a cushioned footbed offers support. ",
//                    Price= 90,
//                    ImageName="5.jpg"
//                },
//                new Product()
//                {
//                    Id =104,
//                    Name = "Jordan Retro 4 Oreos",
//                    Description = "The Air Jordan 4 Retro White Oreo features a white leather and mesh upper with hits of Tech Grey on its eyelets and midsole. From there, a red Jumpman logo is embroidered on the tongue, adding a pop of color to the neutral-toned design. ",
//                    Price= 190,
//                    ImageName="6.jpg"
//                },
//                new Product()
//                {
//                    Id =105,
//                    Name = "Yeezy Boost 350 V2 Dazzling Blue",
//                    Description = "The adidas Yeezy 350 V2 Dazzling Blue is reminiscent of the 2016 Yeezy 350 V2 Black Friday Pack. Instead of featuring a marbled pattern and sheer side stripe, it opts for a solid black Primeknit upper and blue side stripe with SPLY-350 text. r",
//                    Price= 190,
//                    ImageName="7.jpg"
//                }

//            };
//        }

//        public Product GetProduct(int? id)
//        {
//            if (id == null)
//            {
//                return null;
//            }
//            else
//            {
//                return Products.Find(x => x.Id == id);
//            }
//        }

//        public IEnumerable<Product> InitializeData()
//        {

//            return Products;
//        }

//        public void UpdateProduct(Product product)
//        {
//            var prod = Products.Find(x => x.Id == product.Id);
//            if (prod != null)
//            {
//                prod.Id = product.Id;
//                prod.Name = product.Name;
//                prod.Description = product.Description;
//                prod.Price = product.Price;
//                prod.ImageName = product.ImageName;

//            }
//        }
//    }
//}
