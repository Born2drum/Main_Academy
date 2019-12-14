using System;

namespace Lab1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Enter your steps ");
                double a = double.Parse(Console.ReadLine());
                if (a == 3827183 || a == 3817283)
                {
                    Console.WriteLine("It is the right order!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    Console.WriteLine("If you want to exit press 1. To try again press any number");
                    
                    byte b = byte.Parse(Console.ReadLine());
                    if (b == 1)
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}
