using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOConnectDataBaseDemo.Model
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }

        public Product(int productId, string productName, double unitPrice, int unitsInStock, int categoryID)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            CategoryID = categoryID;
        }
    }
}
