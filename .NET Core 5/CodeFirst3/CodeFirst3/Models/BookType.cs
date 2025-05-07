using CodeFirst3.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace CodeFirst3.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType:BaseEntity
    {
        
        public string Name { get; set; }

        //relational property


        public  List<Book> Books { get; set; }
    }
}
