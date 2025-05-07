using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(Product product, string name)
        {

            return "uygulama çalışıyor";
        }

        //Home/index/15/telefon?name=abdullah&surname=yesil

        public string UseQueryString(string name, string surname)
        {

            return "uygulama çalışıyor";
        }
    }
}
