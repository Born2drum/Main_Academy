using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2._2
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  number to calculate the factorial:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(x));
            Console.ReadKey();
        }
    }
}
