﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AutomobileWebApp.DataAccess
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
