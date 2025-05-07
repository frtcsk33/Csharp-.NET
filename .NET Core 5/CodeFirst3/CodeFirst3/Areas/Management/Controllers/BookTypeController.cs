using CodeFirst3.Context;
using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirst3.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookTypeController : Controller
    {

        IRepository<BookType> _repoBookType;
        public BookTypeController(IRepository<BookType> repoBookType)
        {
            _repoBookType = repoBookType;

        }
        public IActionResult BookTypeList()
        {

            List<BookType> bookTypes = _repoBookType.GetAll();
            return View(bookTypes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType booktype)
        {

            if (!ModelState.IsValid)
            {
                return View(booktype);
            }

            _repoBookType.Add(booktype);


            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }


        public IActionResult Edit(int id)
        {


            BookType booktype = _repoBookType.GetById(id);
            return View(booktype);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {

            _repoBookType.Update(bookType);


            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });

        }

        public IActionResult HardDelete(int id)
        {

            _repoBookType.SpecialDelete(id);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }

    }
}
