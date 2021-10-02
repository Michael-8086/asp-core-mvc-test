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

        public string Index()
        {
            return View();
        }

        // 
        // GET: /Test/Welcome/ 

        public string Welcome(string name)
        {
            return $"Hello {name}, welcome to this MVC example!";
        }
    }
}