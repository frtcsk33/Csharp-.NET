using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CodeFirst3.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy ="AdminPolicy")]
    public class AuthorController : Controller
    {
      
        IAuthorRepository _repoAuthor;


        public AuthorController(IAuthorRepository repoAuthor)
        {
            _repoAuthor = repoAuthor;

        }


        
        public IActionResult AuthorList()
        {

            List<Author> authors = _repoAuthor.GetActives(); 
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            _repoAuthor.Add(author);
            return RedirectToAction("AuthorList");
        }

        public IActionResult Edit(int id)
        {
            Author author = _repoAuthor.GetById(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _repoAuthor.Update(author);
            return RedirectToAction("AuthorList", "Author", new {area="Management"});
        }


        public IActionResult Delete(int id)
        {



            _repoAuthor.Delete(id);


            return RedirectToAction("AuthorList","Author", new { area = "Management" });
        }
    }
}

