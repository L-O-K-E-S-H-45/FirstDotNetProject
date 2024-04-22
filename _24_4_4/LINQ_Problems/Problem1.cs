using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_4.LINQ_Problems
{
    internal class Problem1
    {
        public class Customer_P1
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime LastPurchaseDate { get; set; }
            public double TotalPurchaseAmount { get; set; }

            public List<Customer_P1> GetAllCustomers()
            {
                List<Customer_P1> customerList = new List<Customer_P1>()  // without () also works
                {
                    new Customer_P1 { ID = 101, Name = "Tom", LastPurchaseDate = DateTime.Parse("2024-1-26"), TotalPurchaseAmount = 1250 },
                    new Customer_P1() { ID = 108, Name = "John", LastPurchaseDate = DateTime.Parse("2024-4-2"), TotalPurchaseAmount = 450 },
                    new Customer_P1() { ID = 103, Name = "Scott", LastPurchaseDate = DateTime.Parse("2024-3-18"), TotalPurchaseAmount = 740 },
                    new Customer_P1 { ID = 105, Name = "Jerry", LastPurchaseDate = DateTime.Parse("2024-3-8"), TotalPurchaseAmount = 560 },
                    new Customer_P1 { ID = 102, Name = "Miller", LastPurchaseDate = DateTime.Parse("2024-2-13"), TotalPurchaseAmount = 1000 },
                    new Customer_P1 { ID = 104,  Name = "Alice", LastPurchaseDate = DateTime.Now.AddDays(-35), TotalPurchaseAmount = 200 },
                };
                return customerList;

            }
        }
    }
}
