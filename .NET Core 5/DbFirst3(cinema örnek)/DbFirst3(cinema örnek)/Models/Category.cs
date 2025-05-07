using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirst3_cinema_örnek_.Models
{
    public partial class Category
    {
        public Category()
        {
            Films = new HashSet<Film>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
