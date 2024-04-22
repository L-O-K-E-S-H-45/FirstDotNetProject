using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_4.LINQ_Problems
{
    internal class Customer_P5
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Customer_P5> GeAllCustomers()
        {
            return new List<Customer_P5>()
            {
                new Customer_P5 { Id = 1, Name = "Alice" },
                new Customer_P5 { Id = 2, Name = "Bob" },
                new Customer_P5 { Id = 3, Name = "Charlie" }
            };
        }
    }
    internal class  Order_P5
    {   
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }

        public List<Order_P5> GetAllOrders()
        {
            return new List<Order_P5>
            {
                new Order_P5 { OrderId = 101, CustomerId = 1, Amount = 100 },
                new Order_P5 { OrderId = 102, CustomerId = 2, Amount = 150 },
                new Order_P5 { OrderId = 103, CustomerId = 1, Amount = 200 },
                new Order_P5 { OrderId = 104, CustomerId = 3, Amount = 120 }
            };
        }
    }
}
