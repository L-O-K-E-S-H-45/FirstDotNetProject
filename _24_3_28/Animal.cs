using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_28
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog making sound");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat making sound");
        }
    }

    public class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cow making sound");
        }
    }

}
