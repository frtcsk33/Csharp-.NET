﻿using System;
using System.Collections.Generic;

#nullable disable

namespace dbFirst.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
