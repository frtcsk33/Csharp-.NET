using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst3.Models
{
    public class Operation:BaseEntity
    {
        //[Key, Column(Order=1)]
        public int StudentID { get; set; }

        //[Key, Column(Order =2)]
        public int BookID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //relational property


        public  Student Student { get; set; }
        public  Book Book { get; set; }
    }
}
