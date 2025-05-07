using CodeFirst3.Context;
using CodeFirst3.Dto;
using CodeFirst3.Models;
using CodeFirst3.RepositoryPattern.Base;
using CodeFirst3.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirst3.RepositoryPattern.Concrete
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyDbContext db):base(db)
        {
            
        }
        public List<AuthorDto> SelectAuthorDto()
        {
          return table.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new AuthorDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                ID = x.ID

            }).ToList();
        }
    }
}
  
