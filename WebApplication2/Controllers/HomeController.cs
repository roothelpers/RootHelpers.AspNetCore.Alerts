using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestModel
    {
        public int CurrentProgress { get; set; }
        public string Message { get; set; }
        public string Header { get; set; }
    }
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestModel
            {
                Header = "Unable to save form",
                Message = "Please fix the highlighted errors on the form below."
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
