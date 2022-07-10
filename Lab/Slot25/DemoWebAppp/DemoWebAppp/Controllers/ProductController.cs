using DemoWebAppp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAppp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductDetail()
        {
            ViewBag.Product = new Product
            {
                Id = 1,
                Name = "Ca phe",
                Brand = "Viet Nam",
                Price = 1000
            };
            return View();
        }
    }
}
