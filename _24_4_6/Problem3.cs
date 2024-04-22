using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_6
{
    internal class Problem3
    {
        public void Print(int num)
        {
            for (int i = 1; i<= num; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz!!!");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz!!!");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz!!!");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
