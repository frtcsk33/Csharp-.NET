using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){id=1,ProductName="kitap", categoryname="Yazi"},
            new Product(){id=2,ProductName="telefon",categoryname ="Elektronik"},
            new Product(){id=3,ProductName="televizoyn",categoryname="Ev eşyası"},
            new Product(){id=4,ProductName="mouse",categoryname="Elektronik"},
        };
        public IActionResult GetAllProducts()
        {


            return View(products);
        }

        [HttpPost]
        public IActionResult AddProducts(Product p)
        {
            products.Add(p);

            return View("GetAllProducts",products);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.id == id);
            if (product  == null)
            {
                ViewBag.Error = "Verilen id ile bir ürün bulunamadı";
            }

            return View(product);
        }

        public IActionResult GetProductByCategory(string categoryname)
        {
            List<Product> product = products.FindAll(t => t.categoryname == categoryname);
           
            if(product.Count == 0)
            {
                //ViewBag.Error = "Kategori bulunamadı";
                ViewData["Error"] = "İstenilen kategoride veri bulunamadı";
            }

            
            return View(product);
        }
    }
}
