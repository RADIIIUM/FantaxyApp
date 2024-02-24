using FantaxyApp.Models;
using FantaxyApp.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace FantaxyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp(User user)
        {
            if (string.IsNullOrEmpty(user.UserLogin))
            {
                ModelState.AddModelError("LoginError", "Поле логина не должно быть пустым");
                return View("Index");
            }
            if (string.IsNullOrEmpty(user.UserPassword))
            {
                ModelState.AddModelError("PasswordError", "Поле пароля не должно быть пустым");
                return View("Index");
            }
            using (FantaxyDBContext db = new FantaxyDBContext())
            {
                User us = db.Users.FirstOrDefault(x => x.UserLogin == user.UserLogin && x.UserPassword == user.UserPassword);
                if (us == null)
                {
                    ModelState.AddModelError("LoginError", "Неверный логин или пароль");
                    ModelState.AddModelError("PasswordError", "Неверный логин или пароль");
                    return View("Index");
                }
            }
            return Redirect("/FindPage/Find");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}