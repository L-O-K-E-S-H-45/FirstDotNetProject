using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_29
{
    internal class Calculator
    {
        public void calculate<T>(char operand, double x, double y)
        {
            double result = 0;

            switch (operand)
            {
                case '+':
                    result = x + y; break;
                case '-':
                    result = x - y; break;
                case '*':
                    result = x * y; break;
                case '/':
                    if (y == 0)
                    {
                        Console.WriteLine("Invalid denominator"); return;
                    }
                    result = x / y; break;
                default:
                    Console.WriteLine("Invalid choice"); return;

            }
            Console.WriteLine("The result is: " + result);
        }
        public void calculate()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Select type of operation: ");
                Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Exit");

                choice = int.Parse(Console.ReadLine());

                double x = 0;
                double y = 0;

                if (choice >= 1 && choice <= 4)
                {
                    Console.WriteLine("Eneter two values: ");
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                }

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = x + y; break;

                    case 2:
                        result = x - y; break;

                    case 3:
                        result = x * y; break;

                    case 4:
                        if (y == 0)
                        {
                            Console.WriteLine("Invalid denominator"); break;
                        }
                        result = x / y; break;

                    default:
                        Console.WriteLine("Invalid choice!!!"); break;

                }
                if (choice >= 1 && choice <= 4)
                {
                    Console.WriteLine("The result is: " + result);
                    Console.WriteLine("--------- END ---------");
                }

            } while (choice != 5);
        }
    }
}
