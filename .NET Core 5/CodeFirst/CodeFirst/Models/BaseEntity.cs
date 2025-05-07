using CodeFirst.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirst.Models
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        
        public int ID { get; set; }
        public DataStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }



    }
}
