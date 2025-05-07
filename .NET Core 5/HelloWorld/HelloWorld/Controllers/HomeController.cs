using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public string Index() //action
        {
            return "uygulama çalışıyor.";
        }


        public string Test()
        {
            return "Bu test actionıdır";
        }


        public IActionResult Selamla()
        {
            ViewResult result =  View();
            return result;
        }
        public IActionResult Selamla2()
        {
            ViewResult result = View("test2");
            return result;
        }
    }
}
