using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            Console.WriteLine("Enter left position of cursor");
            obj.left = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter top position of cursor");
            obj.top = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of the rectangle:");
            obj.length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of the rectangle:");
            obj.width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the symbol for the border:");
            obj.symbol = Console.ReadLine();
            Console.WriteLine("Enter your text:");
            obj.text = Console.ReadLine();
            
            obj.Draw(obj.left, obj.top, obj.length, obj.width, obj.symbol, obj.text);
        }
    }

    public class Rectangle
    {
        public int left;
        public int top;
        public int length;
        public int width;
        public string symbol;
        public string text;

        public void Draw(int left, int top, int length, int width, string symbol, string text)
        {
            
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(left, top);
                for (int j =0; j< length; j++)
                {
                    if(j == length - 1)
                    {
                        Console.WriteLine(symbol);
                    }
                    else if (i == 0 || i == width - 1)
                    {
                        Console.Write(symbol);
                    }
                    else if (j == 0)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                top += 1;
            }
            Console.SetCursorPosition(left + (length / 2) - (text.Length/2), top - width / 2 );
            Console.Write(text);
            Console.ReadKey();
        }
    }
}
