using CodeFirst3.Context;
using CodeFirst3.Dto;
using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CodeFirst3.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy="AdminPolicy")]
    public class BookController : Controller
    {
        IBookTypeRepository _repoBookType;
        IAuthorRepository _repoAuthor;
        IBookRepository _repoBook;
        MyDbContext _db;
        public BookController(MyDbContext db, IBookRepository repoBook, IAuthorRepository repoAuthor, IBookTypeRepository repoBookType)
        {
            _repoBookType = repoBookType;   
            _repoBook = repoBook; 
            _db = db;
            _repoAuthor = repoAuthor;
        }
        public IActionResult BookList()
        {
            List<Book> books = _repoBook.GetBooks();
            return View(books);

            //bunu dto olarak oluştur view'a gönder ÖDEVVV!!!
        }


        public IActionResult Create()
        {
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();

            List<BookTypeDto> bookTypes = _repoBookType.GetList();
            return View((new Book(),authors, bookTypes));
        }


        [HttpPost]
        public IActionResult Create([Bind(Prefix ="Item1")] Book book)
        {
            _repoBook.Add(book);
           
            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }

        public IActionResult Edit(int id)
        {
            Book book = _db.Books.Find(id);

            List<AuthorDto> authors= _db.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => 
            new AuthorDto() 
            {
                FirstName=x.FirstName,
                ID=x.ID,
                LastName = x.LastName

            }).ToList();

            List<BookTypeDto> bookTypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new BookTypeDto()
            {
                ID=x.ID,
                Name = x.Name

            }).ToList();


            return View((book ,authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            if(book != null)
            {
                book.Status = Enums.DataStatus.Updated;
                book.ModifiedDate = DateTime.Now;

                _db.Books.Update(book);
                _db.SaveChanges();
            }
           


            return RedirectToAction("BookList","Book",new {area="Management"});

        }

        public IActionResult Delete(int id)
        {
            Book book = _db.Books.Find(id);

            _db.Books.Remove(book); // Hard delete
            _db.SaveChanges();

            return RedirectToAction("BookList","Book", new { area = "Management" });
        }
    }
}
