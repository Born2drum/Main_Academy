using System;

namespace Lab1._4
{
    class Program
    {
        enum ComputerType
        {
            desktop,
            laptop,
            server
        }

        struct Computer
        {
            public int CPU;
            public float frequency;
            public int RAM;
            public int memory;
           // public ComputerType type;

        }
        static void Main(string[] args)
        {
            int[][] computers = new int[4][];
            computers[0] = new int[3] { 2, 2, 1 };
            computers[1] = new int[3] { 0, 3, 0 };
            computers[2] = new int[3] { 3, 2, 0 };
            computers[3] = new int[3] { 1, 1, 2 };

            Computer desktop;
            desktop.CPU = 4;
            desktop.frequency = 2.5f;
            desktop.RAM = 6;
            desktop.memory = 500;

            Computer laptop;
            laptop.CPU = 2;
            laptop.frequency = 1.7f;
            laptop.RAM = 4;
            laptop.memory = 250;

            Computer server;
            server.CPU = 8;
            server.frequency = 3f;
            server.RAM = 16;
            server.memory = 2000;


            int CounterDesktop = 0;
            int CounterLaptop = 0;
            int CounterServer = 0;
            int TotalNumber = 0;


            for (int j = 0; j < computers.Length; j++)
            {
                for (int i = 0; i < computers[j].Length; i++)
                {
                   TotalNumber += computers[j][i];

                    if (i == 0)
                    {
                        CounterDesktop += computers[j][0];
                    }
                    else if (i == 1)
                    {
                        CounterLaptop += computers[j][1];
                    }
                    else if (i == 2)
                    {
                        CounterServer += computers[j][2];
                    }
                }
            }
            //int TotalNumber = CounterDesktop + CounterLaptop + CounterServer;
            Console.WriteLine("Number of desktops - " + CounterDesktop);
            Console.WriteLine("Number of laptops - " + CounterLaptop);
            Console.WriteLine("Number of servers - " + CounterServer);
            Console.WriteLine("Total sum of computers = " + TotalNumber);
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            Computer[] ArrayOfComputers = new Computer[3];
            ArrayOfComputers[0] = desktop;
            ArrayOfComputers[1] = laptop;
            ArrayOfComputers[2] = server;
            int Max = 0;
            int IndexMax = 0;
            foreach (Computer i in ArrayOfComputers)
            {
                if (i.memory > Max)
                {
                    Max = i.memory;
                    IndexMax = Array.IndexOf(ArrayOfComputers, i);
                }
            }
            Console.WriteLine("Max memory is "+Max+"GB and it has index "+IndexMax);
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            
                int MinCPU = 10;
                int IndexMinCPU = 0;

                foreach (Computer i in ArrayOfComputers)
                {
                    if (i.CPU < MinCPU)
                    {
                        MinCPU = i.CPU;
                        IndexMinCPU = Array.IndexOf(ArrayOfComputers, i);
                    }
                }

                float MinRAM = 20F;
                int IndexMinRAM = 0;
                foreach (Computer i in ArrayOfComputers)
                {
                    if (i.RAM < MinRAM)
                    {
                        MinRAM = i.RAM;
                        IndexMinRAM = Array.IndexOf(ArrayOfComputers, i);
                    }
                }
                if (IndexMinCPU == IndexMinRAM)
                {
                    Console.WriteLine("Index of computer with min productivity = "+IndexMinRAM);
                }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            desktop.RAM = 8;
            Console.WriteLine("New RAM of desktops = " + desktop.RAM);
            
        }
    }
}
