using CodeFirst3.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace CodeFirst3.Models
{
    [ModelMetadataType(typeof(AuthorMetaData))]
    public class Author:BaseEntity
    {
      
        public string FirstName { get; set; }

       
        //[EmailAddress(ErrorMessage ="Lütfen email formatında veri girin.")]
        public string LastName { get; set; }

        //relational property

        public virtual List<Book> Books {  get; set; }  
    }
}
