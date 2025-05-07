using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Controllers
{
    public class UserController : Controller
    {
        //readonly string userName = "abdullah";
        //readonly string password = "123";
        public IActionResult Index()
        {
            return View();
        }
    }
}
