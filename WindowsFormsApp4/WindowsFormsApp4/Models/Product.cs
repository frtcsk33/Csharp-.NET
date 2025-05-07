using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Models
{
   public class Product
    {
        public Product()
        {
            CreatedDate = DateTime.Now;
        }
        public Product(string productName)
        {
            CreatedDate = DateTime.Now;
            ProductName = productName;
        }
        public string ProductName { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
