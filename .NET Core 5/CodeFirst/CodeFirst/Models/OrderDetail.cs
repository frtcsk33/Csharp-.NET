using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class OrderDetail:BaseEntity
    {
        [Column(Order=3)]
        public short Quantity { get; set; }
        [Column(TypeName ="numeric(18,1)")]
        public decimal? TotalPrice { get; set; }

        //[Key, Column(Order=1)]
        public int OrderID { get; set; }
        //[Key,Column(Order=2)]
        public int ProductID { get; set; }


        //relational property

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
