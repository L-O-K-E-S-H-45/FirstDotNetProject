using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_29
{
    internal class ArrayProblems
    {
        public void PrinArray<T>(T[] array)
        {
            Console.Write("[ ");
            foreach (T ele in array)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine("]");
        }

        public void ReadAndPrintIntegerArray()
        {
            Console.WriteLine("Enter size of Integer Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine($"Eneter {size} Integer elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered Integer Array is: ");
            Console.Write("[ ");
            foreach (int ele in array)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine("]");
        }

        public void ReadAndPrintCharacterArray()
        {
            Console.WriteLine("Enter size of Character Array: ");
            int size = int.Parse(Console.ReadLine());
            char[] array = new char[size];
            Console.WriteLine($"Enter {size} Characters: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered Character Array is: ");
            Console.Write("[ ");
            foreach (char ch in array)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine("]");
        }

        public void ReadAndPrintDoubleArray()
        {
            Console.WriteLine("Enter size of Double Array: ");
            int size = int.Parse(Console.ReadLine());
            double[] array = new double[size];
            Console.WriteLine($"Enter {size} Double elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered Double Array is: ");
            Console.Write("[ ");
            foreach (double ele in array)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine("]");
        }



    }
}
