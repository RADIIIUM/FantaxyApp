using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.IO;
using FantaxyApp.Models.DB;

namespace FantaxyApp.Controllers
{
    public class RegistrationController : Controller
    {


       public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(User user)
        {
            if (string.IsNullOrEmpty(user.UserLogin))
            {
                ModelState.AddModelError("UserLogin", "Поле логина не должно быть пустым");
                return View("Index");
            }
            if (string.IsNullOrEmpty(user.UserPassword))
            {
                ModelState.AddModelError("UserPassword", "Поле пароля не должно быть пустым");
                return View("Index");
            }
            if (string.IsNullOrEmpty(user.UserEmail))
            {
                ModelState.AddModelError("UserEmail", "Некорректный Email");
                return View("Index");
            }
            using (FantaxyDBContext db = new FantaxyDBContext())
            {
                User us = db.Users.FirstOrDefault(x => x.UserLogin == user.UserLogin);
                User email = db.Users.FirstOrDefault(x => x.UserEmail == user.UserEmail);
                if (us != null)
                {
                    ModelState.AddModelError("UserLogin", "Данный пользователь уже существует");
                    return View("Index");
                }
                if (email != null)
                {
                    ModelState.AddModelError("UserEmail", "Данный Email уже зарегестрирован");
                    return View("Index");
                }
                User u = new User();
                u.UserLogin = user.UserLogin;
                u.UserPassword = user.UserPassword;
                u.UserEmail = user.UserEmail;
                UsersInfo ui = new UsersInfo();
                if (ViewBag.Avatar != null)
                {
                    ui.UserLogin = u.UserLogin;
                    ui.UserName = u.UserLogin;
                    ui.Avatar = ViewBag.Avatar;
                }
                else
                {
                    ui.UserLogin = u.UserLogin;
                    ui.UserName = u.UserLogin;
                    ui.Avatar = System.IO.File.ReadAllBytes("./stdAvatar.png");
                }

                db.Users.Add(u);
                ViewBag.Success = $"Пользователь {u.UserLogin} успешно создан!";
                db.SaveChanges();
            }
            return View("Index");
        }


        [HttpPost]
        public IActionResult UploadImage(IFormFile Avatar)
        {
            ViewData["ShowAlert"] = false;
            if (Avatar == null)
            {
                ViewData["Message"] = "Вы не выбрали изображение. Нажмите на картинку";
                ViewData["ShowAlert"] = true; // Флаг для показа alert
                return View("Index");
            }
            ViewBag.Avatar = ConvertIFormFileToByteArray(Avatar);
            return View("Index");
        }

        public byte[] ConvertIFormFileToByteArray(IFormFile file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                if (file == null)
                {
                    ViewData["Message"] = "Ошибка ArgumentNullException!";
                    ViewData["ShowAlert"] = true; // Флаг для показа alert
                    throw new ArgumentNullException(nameof(file), "File is null");
                }

                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
