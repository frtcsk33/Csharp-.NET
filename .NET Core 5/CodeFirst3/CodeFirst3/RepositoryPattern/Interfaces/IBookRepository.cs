using CodeFirst3.Models;
using System.Collections.Generic;

namespace CodeFirst3.RepositoryPattern.Interfaces
{
    public interface IBookRepository:IRepository<Book>
    {
        List<Book> GetBooks();
    }
}
