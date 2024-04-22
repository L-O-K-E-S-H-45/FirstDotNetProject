using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._28_3_24
{
    internal class MainRunner
    {
        public static  void Main(String[] args)
        {
            Animal animal = new Dog();
            animal.MakeSound();

            animal = new Cat();
            animal.MakeSound();

            animal = new Cow();
            animal.MakeSound();

            //--------------------------
            Console.WriteLine("2nd problem IShape interface");
            IShape shape = new Circle();
            Console.WriteLine($"Area of circle: {shape.CalculateArea()}");

            shape = new Rectangle();
            Console.WriteLine($"Area of rectangle: {shape.CalculateArea()}");


        }

    }
}
