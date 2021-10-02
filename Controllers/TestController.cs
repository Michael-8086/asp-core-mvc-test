using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace asp_core_mvc_test.Controllers
{
    public class TestController : Controller
    {
        // 
        // GET: /Test/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Test/Welcome/ 

        public IActionResult Welcome(string name)
        {
            if (name != null)
            {
                ViewData["Message"] = $"Hello {name}, welcome to this MVC example!";
            }
            else
            {
                ViewData["Message"] = "You have not entered a name!";
            }
            return View();
        }
    }
}