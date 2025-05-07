using DbFirst3_cinema_örnek_.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbFirst3_cinema_örnek_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
