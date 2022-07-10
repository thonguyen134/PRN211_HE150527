using Microsoft.AspNetCore.Mvc;
using DemoWebAppp.Models;
using Microsoft.AspNetCore.Http;

namespace DemoWebAppp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }
        public string List()
        {
            return "list page";
        }
    }
}
