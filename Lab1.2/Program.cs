using System;

namespace Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)
            bool boo = true;
            char ch = ' ';
            byte b = 1;
            sbyte sb = -100;
            short sh = 150;
            ushort ush = 65000;
            int i = -223;
            uint ui = 300;
            long l = -9000000;
            ulong ul = 10000;
            decimal de = -33.1M;
            float fl = 100000.6F;
            double d0 = 250.7;







            //2) declare constants of int and double. Try to change their values.
            const int a = 128;
            const double c = 2345894.9;


            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?
            var a1 = 20;
            var a2 = 20.5;
            //We can't change int type of a1 to double, but we can write 20 to double var


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?
            int axe = -223;
            double bob = 250.7;



            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //It is impossible because we can't create variables with the same type

                // 6) change values of variables from 1)


            }

            // 7)check values of variables from 1). Are they changed? Think, why


            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char

            // bool -> short

            // double -> long

            // float -> char 

            // int to char

            // decimal -> double

            // byte -> uint

            // ulong -> sbyte

            // 9) and reverse conversion with fixing compilation errors.


            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?

        }
    }
}
