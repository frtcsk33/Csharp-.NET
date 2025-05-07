using CodeFirst3.Dto;
using CodeFirst3.Models;
using System.Collections.Generic;

namespace CodeFirst3.RepositoryPattern.Interfaces
{
    public interface IBookTypeRepository:IRepository<BookType>
    {
        List<BookTypeDto> GetList();
    }
}
