using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_28.OOP
{
    public class Employee
    {
        
        public string Name;
        public int EmployeeId;
        public double Salary;
        public Employee(string name, int employeeId, double salary)
        {
            this.Name = name;
            this.EmployeeId = employeeId;
            this.Salary = salary;
        }
        public virtual void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Employee ID: {EmployeeId}, Salary: {Salary} Rs.");
        }
    }
    public class Manager : Employee
    {
        public string Department;
        public Manager(string name, int employeeId, double salary, string department)
            : base(name, employeeId, salary)
        {
            this.Department = department;
        }
        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"Department: {Department}");
        }
    }
    public class Developer : Employee
    {
        public string DeveloperType;
        public Developer(string name, int employeeId, double salary, string DeveloperType)
            : base(name, employeeId, salary)
        {
            this.DeveloperType = DeveloperType;
        }
        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"DeveloperType: {DeveloperType}");
        }
    }
    public class HR : Employee
    {
        public string Responsibilities;
        public HR(string name, int employeeId, double salary, string responsibilities)
            : base(name, employeeId, salary)
        {
            this.Responsibilities = responsibilities;
        }
        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"Responsibilities: {Responsibilities}");
        }
    }

    class Program
    {
        static void MainMethod(string[] args)
        {
            // Example usage
            Manager manager = new Manager("John Doe", 1001, 75000, "Sales");
            Developer developer = new Developer("Alice Smith", 2001, 60000, "C#");
            HR hr = new HR("Emily Johnson", 3001, 55000, "Recruitment");

            Console.WriteLine("Manager Information:");
            manager.DisplayEmployeeInfo();

            Console.WriteLine("\nDeveloper Information:");
            developer.DisplayEmployeeInfo();

            Console.WriteLine("\nHR Information:");
            hr.DisplayEmployeeInfo();
        }
    }

}
