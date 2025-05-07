using dbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace dbFirst.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        public CategoryController(NorthwindContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
