using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DemoASP.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string list()
        {
            return "abc";
        }
    }
}
