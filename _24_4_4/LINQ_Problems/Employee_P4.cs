using FirstProject._28_3_24.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_4.LINQ_Problems
{
    internal class Employee_P4
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public List<Employee_P4> GetAllEmployees()
        {
            return new List<Employee_P4>
            {
                new Employee_P4 { Name = "John", Salary = 50000 },
                new Employee_P4 { Name = "Alice", Salary = 60000 },
                new Employee_P4 { Name = "Bob", Salary = 45000 },
                new Employee_P4 { Name = "Emma", Salary = 70000 },
                new Employee_P4 { Name = "Mike", Salary = 55000 }
            };
        }
    }
}
