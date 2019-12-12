using System;

namespace Lab1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            decimal factorial = 1;

            for (int i = a; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial = " + factorial);
        }
    }
}
