using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){id=1, Name="Fırat", Gender="man" },
            new Teacher(){id=2, Name="Hakan", Gender="man" },
            new Teacher(){id=3, Name="Esma", Gender="woman" },
            new Teacher(){id=4, Name="Feyza", Gender="woman" },
        };
        public IActionResult GetTeacherList()
        {
            return View(teachers);
        }


        public IActionResult DeleteTeacherList(int id)
        {
            Teacher teacher = teachers.Find(x => x.id == id);
            return View(teacher);
        }
    }
}
