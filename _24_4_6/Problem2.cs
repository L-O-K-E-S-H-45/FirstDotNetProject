using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_6
{
    internal class Problem2
    {

        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public double ProductPrice { get; set; }
            public int ProductQuantity { get; set; }
            public int CategoryId { get; set; }
            public int SupplierId { get; set; }

        }
        public class Catagory
        {
            public int Id { get; set; }
            public string CatagoryName { get; set; }

        }
        public class Supplier
        {
            public int Id { get; set; }
            public string SupplierName { get; set; }
        }

    }
}
