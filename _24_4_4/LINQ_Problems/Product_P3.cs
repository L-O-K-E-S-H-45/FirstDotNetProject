using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstProject._24_4_6.Problem2;

namespace FirstProject._24_4_4.LINQ_Problems
{
    internal class Product_P3
    {
        public string ProductName { get; set; }
        public double   ProductPrice { get; set; }

        public List<Product_P3> GetAllProducts()
        {
            return new List<Product_P3>
            {
                new Product_P3 { ProductName = "Laptop", ProductPrice = 1200 },
                new Product_P3 { ProductName = "Smartphone", ProductPrice = 800 },
                new Product_P3 { ProductName = "Tablet", ProductPrice = 600 },
                new Product_P3 { ProductName = "Headphones", ProductPrice = 150 },
                new Product_P3 { ProductName = "Keyboard", ProductPrice = 100 }
            };
        }
    }
}
