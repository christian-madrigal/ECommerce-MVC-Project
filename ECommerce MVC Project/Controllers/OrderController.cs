using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce_MVC_Project.DB_Data;
using ECommerce_MVC_Project.Models;
using ECommerce_MVC_Project.Utility;
using ECommerce_MVC_Project.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;



namespace ECommerce_MVC_Project.Controllers
{

    public class OrderController : Controller
    {
        private ApplicationDbContext _db;



        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET Checkout actioin method

        public IActionResult Checkout()
        {
            return View();
        }



        //POST Checkout action method

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Customer")]
        public IActionResult Checkout(Order order)
        {
            List<Product> products = HttpContext.Session.Get<List<Product>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.ProductId = product.Id;
                    order.OrderDetails.Add(orderDetails);
                }
            }




            List<Customer> customers = HttpContext.Session.Get<List<Customer>>("customers");
            if (customers != null)
                foreach (var customer in customers)
                {
                    if (ModelState.IsValid)
                    {
                        var CustomerId = Convert.ToString(User.Identity.GetHashCode());
                        //var UserId = User.Identity.GetHashCode();
                        OrderDetails orderDetails = new OrderDetails();
                        orderDetails.UserId = CustomerId;
                        order.OrderDetails.Add(orderDetails);
                    }
                }
            

            order.OrderNo = GetOrderNo();
            _db.Orders.Add(order);
            _db.SaveChanges();
            //await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Product>());
            HttpContext.Session.Set("customerId", new List<Customer>());
            return View();
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Orders = _db.Orders.ToList();
            return View(_db.Orders.ToList());


        }

        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var order = _db.Orders.FirstOrDefault(c => c.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            
            return View(order);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Update(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var order = _db.Orders
                .FirstOrDefault(c => c.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Order orders)
        {

            _db.Orders.Update(orders);
            await _db.SaveChangesAsync();
            return View(orders);
        }




        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var order = _db.Orders.FirstOrDefault(c => c.Id == id);
            _db.Orders.Remove(order);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



        public string GetOrderNo()
        {
            int rowCount = _db.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }
    }
}

