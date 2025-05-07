using CodeFirst3.Enums;
using System;
using System.Threading.Tasks.Dataflow;

namespace CodeFirst3.Models
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
