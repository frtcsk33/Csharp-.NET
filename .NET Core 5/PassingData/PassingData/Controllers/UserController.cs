using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
            {
                new User(){FirstName ="Safa", LastName="Başdemir"},
                new User(){FirstName ="Fırat", LastName ="Çoşkun"},
                new User(){FirstName="Yılmaz", LastName="Çoşkun"}

            };
        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Abdullah";

            User user = new User();

            user.FirstName = "Emirhan";
            user.LastName = "Yeşil";
            ViewBag.User = user;


            ViewBag.Users = users;
            return View();
        }


        public IActionResult UseViewData()
        {

            ViewData["UserName"] = "Abdullah";

            User user = new User();
            user.FirstName = "Emirhan";
            user.LastName = "Yeşil";

            ViewData["User"] = user;
            ViewData["Users"] = users;

            return View();
        }

        public IActionResult UseTempData()
        {
            TempData["name"] = "abdullah";

            return RedirectToAction("TempDataTest");
        }

        public IActionResult TempDataTest()
        {
            TempData.Keep("name");
            //string userName = TempData["name"].ToString();
            return View();
        }
    }
}
