using Microsoft.AspNetCore.Mvc;
using ECommerce_MVC_Project.Models;
using ECommerce_MVC_Project.Filters;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ECommerce_MVC_Project.DB_Data;

namespace ECommerce_MVC_Project.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _db;


        public CustomerController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Details(string id)
        {

            var customer  = _db.Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        public IActionResult Users()
        {
            IndexViewModel model = new IndexViewModel();
            model.Customers = _db.Customers.ToList();
            return View(_db.Customers.ToList());
        }
        
        [HttpGet]
        public ActionResult Update(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var customer = _db.Customers
                .FirstOrDefault(c => c.Id==id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Customer customers)
        {

            _db.Customers.Update(customers);
            await _db.SaveChangesAsync();
            return View(customers);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var customer = _db.Customers.FirstOrDefault(c => c.Id == id);
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
            return RedirectToAction("Users");
        }
    }
}
