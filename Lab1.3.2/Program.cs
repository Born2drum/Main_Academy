using System;

namespace Lab1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите другое число: ");
            double second = Convert.ToDouble(Console.ReadLine());
            long a;
            Console.WriteLine(@"Select the arithmetic operation:
            1. Multiplication 
            2. Divide 
            3. Addition 
            4. Subtraction
            5. Exponentiation ");
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Результатом умножения есть " + (first * second));
                    break;
                case 2:
                    Console.WriteLine("Результатом деления есть " + first / second);
                    break;
                case 3:
                    Console.WriteLine("Результатом сумирования есть " + (first + second));
                    break;
                case 4:
                    Console.WriteLine("Результатом вычитания есть " + (first - second));
                    break;
                case 5:
                    Console.WriteLine("Результатом поднесения к степени есть " + (Math.Pow(first, second)));
                    break;
                default:
                    Console.WriteLine("Введите одно из этих чисел");
                    break;


            }


        }
    }
}
