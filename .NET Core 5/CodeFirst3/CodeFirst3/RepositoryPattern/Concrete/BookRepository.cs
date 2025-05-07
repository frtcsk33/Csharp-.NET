using CodeFirst3.Context;
using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Base;
using CodeFirst3.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirst3.RepositoryPattern.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {

        public BookRepository(MyDbContext db) : base(db)
        {
        }

        public List<Book> GetBooks()
        {
           return table.Where(b => b.Status != Enums.DataStatus.Deleted).Include(x => x.Author).Include(x => x.BookType).ToList();
        }
    }
}
