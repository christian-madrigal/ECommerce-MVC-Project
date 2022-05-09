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
    public class ProductController : Controller
    {
        private ApplicationDbContext _db;


        public ProductController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products.FirstOrDefault(c => c.Id == id);
             
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [SimpleActionFilter]
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products= _db.Products.ToList();
            return View(_db.Products.ToList());
        }

        //POST Index action method
        [HttpPost]
        public IActionResult Index(decimal? lowAmount, decimal? largeAmount)
        {
            var products = _db.Products
                .Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
            if (lowAmount == null || largeAmount == null)
            {
                products = _db.Products.ToList();
            }
            return View(products);
        }

        //Get Create method
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            return View();
        }


        //Post Create method
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                //var searchProduct = _db.Products.FirstOrDefault(c => c.Name == product.Name);
                //if (searchProduct != null)
                //{
                //    ViewBag.message = "This product is already exist";
                //    return View(product);
                //}

                //if (image == null)
                //{
                //    product.ImageName = "Images/noimage.PNG";
                //}
                
                _db.Products.Add(product);
                _db.SaveChanges();
                //await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        [Authorize(Roles ="Admin")]
        public ActionResult Update(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.Products
                .FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }


        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Update(Product products)
        {

            _db.Products.Update(products);
            await _db.SaveChangesAsync();
            return View(products);
        }




        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = _db.Products.FirstOrDefault(c => c.Id == id);
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //[Authorize(Roles = "Admin")]
        //public ActionResult Delete(int? id)
        //{
        //    //if (id == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    var product = _db.Products.FirstOrDefault();
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}


        //[HttpPost]
        //[Authorize(Roles = "Admin")]
        //[ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirm(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = _db.Products.FirstOrDefault(c => c.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.Products.Remove(product);
        //    await _db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
