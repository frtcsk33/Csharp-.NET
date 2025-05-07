using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(){FirstName="abdullah", LastName ="Yeşil"},
            new Customer(){FirstName="Fırat", LastName ="Çoşkun"},
            new Customer(){FirstName="Yasin ", LastName ="Uslu"}
        };

        public IActionResult UseViewModel()
        {

            Product product = new Product();
            product.CategoryName = "elektronik";
            product.productName = "Monitör";
            product.UnitPrice = 1;

            string date = DateTime.Now.ToString();

            CustomerAndProductVM customerAndProduct = new CustomerAndProductVM();

            customerAndProduct.customers = customers;
            customerAndProduct.date = date;
            customerAndProduct.product = product;

            return View(customerAndProduct);
        }


        public IActionResult UseTuple()
        {
            Product product = new Product();
            product.CategoryName = "elektronik";
            product.productName = "TElefon";
            product.UnitPrice = 4;

            string date = DateTime.Now.ToString();

            (List<Customer>, Product, string) customerAndProduct  = (customers, product, date);

            return View(customerAndProduct);
        }
    }
}
