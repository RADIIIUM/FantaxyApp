using FantaxyApp.Models;
using FantaxyApp.Models.DB;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.VisualBasic;

namespace FantaxyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var obj = Request.Cookies["Login"];
            if (obj == null)
            {
                return View();
            }
            else
            {
                using (FantaxyDBContext db = new FantaxyDBContext())
                {
                    string role = db.Roles.FirstOrDefault(x => x.IdRole == (db.RolesUsers.FirstOrDefault(y => y.UserLogin == obj).IdRole)).RoleName;
                    GlobalParameters.Users = db.Users.FirstOrDefault(x => x.UserLogin == obj); ;
                    GlobalParameters.UserInfo = db.UsersInfos.FirstOrDefault(x => x.UserLogin == obj);
                    GlobalParameters.UserRole = role;
                }
                return Redirect("/FindPage/Find");
            }
        }

        [HttpPost]
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
                string role = db.Roles.FirstOrDefault(x => x.IdRole == (db.RolesUsers.FirstOrDefault(y => y.UserLogin == user.UserLogin).IdRole)).RoleName;
                GlobalParameters.Users = user;
                GlobalParameters.UserInfo = db.UsersInfos.FirstOrDefault(x => x.UserLogin == user.UserLogin);
                GlobalParameters.UserRole = role;

                CookieOptions obj = new CookieOptions();
                obj.Expires = DateAndTime.Now.Add(new TimeSpan(7, 0, 0, 0, 0));
                Response.Cookies.Append("Login", user.UserLogin, obj);

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