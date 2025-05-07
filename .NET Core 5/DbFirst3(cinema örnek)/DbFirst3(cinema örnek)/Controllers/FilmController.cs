using DbFirst3_cinema_örnek_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DbFirst3_cinema_örnek_.Controllers
{
    public class FilmController : Controller
    {
        CinemaDBContext _db;

        public FilmController(CinemaDBContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            List<Film> films = _db.Films.ToList(); 
            return View(films);
        }
    }
}
