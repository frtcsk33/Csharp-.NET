using CodeFirst3.Context;
using CodeFirst3.Dto;
using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Base;
using CodeFirst3.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirst3.RepositoryPattern.Concrete
{
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {

        public BookTypeRepository(MyDbContext db):base(db)
        {
            
        }
        public List<BookTypeDto> GetList()
        {
          return table.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new BookTypeDto()
            {
                ID = x.ID,
                Name = x.Name

            }).ToList();
        }
    }
}
