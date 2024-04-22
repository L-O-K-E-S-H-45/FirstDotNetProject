using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_28
{
    internal interface IShape
    {
       public abstract double CalculateArea();
    }

    public class Circle : IShape
    {
        public double CalculateArea() // we should not use override keyword for interface implementation
        {
            Console.WriteLine("Enter the radius: ");
            double radius = double.Parse(s:Console.ReadLine());
            double area = 3.142*radius*radius;
            return area;

        }
    }

    public class Rectangle : IShape
    {
        public double CalculateArea()
        {
            Console.WriteLine("Enter length of Rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of Rectangle: ");
            int breadth = int.Parse(Console.ReadLine());
            double area = length* breadth;
            return area;
        }
    }

}
