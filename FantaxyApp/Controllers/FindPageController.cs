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

        [HttpGet]
        public IActionResult Profile()
        {
            return Redirect("/MainProfile/Profile");
        }
    }
}
