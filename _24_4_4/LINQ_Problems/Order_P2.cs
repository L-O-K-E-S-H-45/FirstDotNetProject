using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_4.LINQ_Problems
{
    internal class Order_P2
    {
        public string Name { get; set; }
        public string Catagory { get; set; }
        public decimal Price { get; set; }

        public List<Order_P2> GetAllOrders()
        {
            return new List<Order_P2> // with () also works
            { 
                new Order_P2() {Name = "Moblie", Catagory = "Electronics", Price = 18500},
                new Order_P2() {Name = "Laptop", Catagory = "Electronics", Price = 54000},
                new Order_P2 {Name = "Watch", Catagory = "Electronics", Price = 1400},
                new Order_P2 {Name = "Shirt", Catagory = "Clothing", Price = 850},
                new Order_P2 {Name = "T-Shirt", Catagory = "Clothing", Price = 400},
                new Order_P2 {Name = "Nike", Catagory = "Shoes", Price = 2500},
            };
        }
    }
}
