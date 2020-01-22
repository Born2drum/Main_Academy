using System;
using System.Collections.Generic;

namespace Lab1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int dif =  a- b ;
            if (dif < 0)
            {
                dif *= -1;
            }
            Console.WriteLine("Absolute difference = " + dif);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");


            double unaryA = 0;
            for (int i =0; i<a; i++)
            {
                unaryA += Math.Pow(10, i);
            }
            double unaryB = 0;
            for (int i = 0; i < b; i++)
            {
                unaryB += Math.Pow(10, i);
            }
            double unaryDif = 0;
            for (int i = 0; i < dif; i++)
            {
                unaryDif += Math.Pow(10, i);
            }

            Console.WriteLine("Unary a = " + unaryA+ "\r\nUnary b = " + unaryB + "\r\nUnary difference = " + unaryDif);
        }
    }
}
