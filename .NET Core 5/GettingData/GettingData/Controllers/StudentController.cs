using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(){firstName="Fırat", lastName="Çoşkun"},
            new Student(){firstName="Veli", lastName="Sanrı"},
            new Student(){firstName="Alperen", lastName="mantaş"},
            new Student(){firstName="Diyar", lastName="Kandemir"},
        };

        public IActionResult GetStudentList()

        {
            return View(students);
        }


        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);

            return View("GetStudentList",students);
        }
    }
}
