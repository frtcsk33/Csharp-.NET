using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class UserController : Controller
    {

        List<User> users = new List<User>()
        {
            new User(){firstName="Fırat", lastName="Çoşkun"},
            new User(){firstName="Alperen", lastName="Mantaş"},
            new User(){firstName="Veli", lastName="Sanrı"},
            new User(){firstName="Mehmet", lastName="Çetin"},
        };


        [HttpGet]
        public IActionResult GetUserList()
        {

            return View(users);
        }


        [HttpPost]
        public IActionResult AddUser(User user)
        {
            users.Add(user);

            return View("GetUserList", users);
        }
    }
}
