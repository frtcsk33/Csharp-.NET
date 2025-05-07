using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "abdullah onur";
            return View(userName as Object);
         }

        public IActionResult UrunGoster()
        {
            Product product = new Product();
            product.productName = "Televizyon";
            product.UnitPrice = 5;
            return View(product);
        }


        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){productName="Bilgisayar", CategoryName="Elektronik",UnitPrice=7},
                 new Product(){productName="Teleofn", CategoryName="Elektronik",UnitPrice=5},
                  new Product(){productName="Buzdolabı", CategoryName="Beyaz Eşya",UnitPrice=7},
                   new Product(){productName="Koltuk",
                CategoryName="Ev eşyası",UnitPrice=7}
            };
            

            return View(products);
        }
    }
}
