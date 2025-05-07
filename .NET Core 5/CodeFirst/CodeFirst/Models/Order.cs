using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Order:BaseEntity
    {
        
        public int AppUserID { get; set; }//foreign key

        //relational property

      
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
