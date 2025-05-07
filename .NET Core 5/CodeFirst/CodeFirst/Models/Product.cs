using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("Ürünler")]
    public class Product:BaseEntity
    {
        [Column("Ürün İsmi", TypeName ="nvarchar(50)"), Required, MinLength(5)]
        
        public string ProductName { get; set; }

        [Column("Birim Fiyatı", TypeName ="numeric(18,1)")]
        public decimal? UnitPrice { get; set; }

        public short UnitsInStock { get; set; }

        public int CategoryID { get; set; } // foreign key

        //relational property

        

        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
