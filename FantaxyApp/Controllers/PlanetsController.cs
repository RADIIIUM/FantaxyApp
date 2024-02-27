using Microsoft.AspNetCore.Mvc;

namespace FantaxyApp.Controllers
{
    public class PlanetsController : Controller
    {
        public IActionResult Enter()
        {
            return View();
        }
    }
}
