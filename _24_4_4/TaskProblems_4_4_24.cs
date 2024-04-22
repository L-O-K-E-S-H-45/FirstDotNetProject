using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FirstProject._24_4_4
{
    internal class TaskProblems_4_4_24
    {
        internal class MyList
        {
            public void FindOddAndEvenNumbers(List<int> list)
            {
                List<int> oddNumbers = new List<int>();
                List<int> evenNumbers = new List<int>();

                foreach (int number in list)
                {
                    if (number%2 != 0)
                        oddNumbers.Add(number);
                    else
                        evenNumbers.Add(number);
                }

                Console.WriteLine("Odd numbers list: ");
                PrintList(oddNumbers);

                Console.WriteLine("Even numbers list: ");
                PrintList(evenNumbers);

            }

            public void PrintList(List<int> list)
            {
                Console.Write("[ ");
                foreach (int ele in list) Console.Write(ele + " ");
                Console.WriteLine("]");
            }

            public string FindMaxString(List<string> list)
            {
                string max = "";
                foreach (string str in list)
                {
                    if (str.Length > max.Length)
                        max = str;
                }
                return max;
            }

        }
    }
}
