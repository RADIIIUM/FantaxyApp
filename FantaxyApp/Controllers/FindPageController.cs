using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;


namespace FantaxyApp.Controllers
{
    public class FindPageController : Controller
    {
        public IActionResult Find()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Planets()
        {
            return View();
        }
    }
}
