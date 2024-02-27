using FantaxyApp.Models;
using FantaxyApp.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace FantaxyApp.Controllers
{
    public class MainProfileController : Controller
    {

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult EditProfile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            
            Response.Cookies.Delete("Login");
            return Redirect("/Home/Index");
        }

        [HttpPost]
        public IActionResult DonwloadAvatar(IFormFile avatarImage)
        {
            ViewData["ShowAlert"] = false;
            if (avatarImage == null)
            {
                ViewData["Message"] = "Вы не выбрали изображение. Нажмите на картинку";
                ViewData["ShowAlert"] = true; // Флаг для показа alert
                return View("EditProfile");
            }
            ViewBag.avatar = ConvertIFormFileToByteArray(avatarImage);
            return View("EditProfile");
        }

        [HttpPost]
        public IActionResult DonwloadMainImage(IFormFile mainImage)
        {
            ViewData["ShowAlert"] = false;
            if (mainImage == null)
            {
                ViewData["Message"] = "Вы не выбрали изображение. Нажмите на картинку";
                ViewData["ShowAlert"] = true; // Флаг для показа alert
                return View("EditProfile");
            }
            ViewBag.mainimage = ConvertIFormFileToByteArray(mainImage);
            return View("EditProfile");
        }

        [HttpPost]
        public IActionResult DonwloadSecondImage(IFormFile secondImage)
        {
            ViewData["ShowAlert"] = false;
            if (secondImage == null)
            {
                ViewData["Message"] = "Вы не выбрали изображение. Нажмите на картинку";
                ViewData["ShowAlert"] = true; // Флаг для показа alert
                return View("EditProfile");
            }
            ViewBag.secondimage = ConvertIFormFileToByteArray(secondImage);
            return View("EditProfile");
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
