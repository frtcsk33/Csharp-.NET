﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
