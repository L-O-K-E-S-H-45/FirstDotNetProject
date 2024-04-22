using FirstProject._24_3_28;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_28
{
    internal class MainRunner
    {
        public static void MainMethod()
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
