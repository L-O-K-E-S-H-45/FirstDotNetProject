using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_1
{
    internal class TaskProblems_1_4_24
    {

        public void Swap1<T>(ref T x, ref T y) // ************************
        {
            Console.WriteLine($"Values before swap: {x} {y}");
            T temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"Values after swap: {x} {y}");
        }
        public void Swap<T>(T x, T y)
        {
            Console.WriteLine($"Values before swap: {x} {y}");
            T temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"Values after swap: {x} {y}");
        }

        public void PrintArray<T>(T[] array)
        {
            Console.Write("[ ");
            foreach (T ele in array)    Console.Write(ele + " ");
            Console.WriteLine("]");
        }
        public void ReverseArray<T>(T[] arr)
        {
            Console.WriteLine("Array before Reverse: ");
            PrintArray(arr);

            //int i = 0, j = arr.Length-1;
            //while (i< j)
            //{
            //    T temp = arr[i];
            //    arr[i] = arr[j];
            //    arr[j] = temp;
            //    i++;
            //    j--;
            //}

            int n = arr.Length;
            for (int i = 0; i< n/2; i++)
            {
                T temp = arr[i];
                arr[i] = arr[n-1-i];
                arr[n - 1 - i] = temp;
            }

            Console.WriteLine("Array before Reverse: ");
            PrintArray(arr);
        }

    }
}
