using System.Collections.Generic;

namespace CodeFirst3.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }

        public string PageCount { get; set; }

        public int AuthorID { get; set; }//foreign key
        public int BookTypeID { get; set; } //foreign key

        //relational property

        public  Author Author { get; set; }

        public  BookType BookType { get; set; }

        public  List<Operation> Operations { get; set; }

    }
}
