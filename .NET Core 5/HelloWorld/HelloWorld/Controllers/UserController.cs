﻿using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetUser()
        {
            User user = new User();
            user.ID = 1;
            user.FirstName = "Fırat";
            user.LastName = "Yeşil";
            return View();
        }

        [NonAction]
        public string GetFullName(User user)
        {
            return user.FirstName + "  " + user.LastName;
        }
    }
}
