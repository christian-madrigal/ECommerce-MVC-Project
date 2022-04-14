using Microsoft.AspNetCore.Mvc;

namespace ECommerce_MVC_Project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
