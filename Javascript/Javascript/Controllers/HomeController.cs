using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Javascript.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult JavaScript1()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }
        public IActionResult Calculator2()
        {
            return View();
        }
    }
}