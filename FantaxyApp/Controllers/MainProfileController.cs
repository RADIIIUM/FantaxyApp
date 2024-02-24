using Microsoft.AspNetCore.Mvc;

namespace FantaxyApp.Controllers
{
    public class MainProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
