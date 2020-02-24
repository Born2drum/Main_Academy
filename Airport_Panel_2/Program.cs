using System;
using System.Collections.Generic;

namespace Airport_Panel_2
{
    class Flight
    {
        public DateTime date;
        public int flightNumber;
        public string city;
        public string airline;
        public string terminal;
        public string status;
        public int gate;

        /* public Flight(DateTime date, int flightNumber, string city, string airline, string terminal, string status, int gate)
          {
              this.date = date;
              this.city = city;
              this.flightNumber = flightNumber;
              this.airline = airline;
              this.terminal = terminal;
              this.status = status;
              this.gate = gate;
          }*/

        public void Output()
        {
            Console.WriteLine($" date of arrival: {date}    number of flight: {flightNumber}    city: {city}    airline: {airline}    terminal: {terminal}    gate: {gate} ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");

        }



    }
    public enum Actions
    {
        delete,
        add,
        edit
    };
    static class Methods
    {
        public static void Delete(List<Flight> flights)
        {
            Console.WriteLine("Enter the index of the element which you want to delete: ");
            int del;
            del = int.Parse(Console.ReadLine());
            flights.Remove(flights[del]);
        }
        public static void Add(List<Flight> flights)
        {
            Console.WriteLine("Enter on which position you want to add a new element: ");
            int n;
            n = int.Parse(Console.ReadLine());
            flights.Insert(n, new Flight());
            flights[n].date = DateTime.Parse(Console.ReadLine());
            flights[n].city = Console.ReadLine();
            flights[n].flightNumber = int.Parse(Console.ReadLine());
            flights[n].airline = Console.ReadLine();
            flights[n].terminal = Console.ReadLine();
            flights[n].status = Console.ReadLine();
            flights[n].gate = int.Parse(Console.ReadLine());
        }
        public static void Edit()
        {
            Console.WriteLine("Enter the index of the element which you want to edit");
            int d = int.Parse(Console.ReadLine());


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Random rnd = new Random();
            String[] cities = { "Kyiv", "Boryspil", "Viena", "Los Angeles", "Moskow", "Minsk", "Warsaw" };
            String[] airlines = { "7up", "MAU", "Turkish Airlines", "Emirates", "Ryanair", "Wizz Air" };
            int[] flightNumbers = new int[10];
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                flightNumbers[i] = rnd.Next(50);
            }
            String[] terminals = { "D1", "D2", "D3", "D4" };
            String[] statuses = { "checkIn", "gateClosed", "arrived", "departed", "unknown", "canceled", "expected", "delayed", "inFlight" };
            int[] gates = new int[10];

            for (int i = 0; i < gates.Length; i++)
            {
                gates[i] = rnd.Next(50);
            }

            List<Flight> flights = new List<Flight>();

            for (int i = 0; i < n; i++)
            {
                flights.Add(new Flight());
                flights[i].date = (DateTime.Now + TimeSpan.FromHours(2.0));
                flights[i].city = cities[rnd.Next(0, cities.Length)];
                flights[i].flightNumber = flightNumbers[rnd.Next(0, flightNumbers.Length)];
                flights[i].airline = airlines[rnd.Next(0, airlines.Length)];
                flights[i].terminal = terminals[rnd.Next(0, terminals.Length)];
                flights[i].status = statuses[rnd.Next(0, statuses.Length)];
                flights[i].gate = gates[rnd.Next(0, gates.Length)];
            }

            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].Output();
            }

            Actions ac = (Actions)Enum.Parse(typeof(Actions), Console.ReadLine());
            switch (ac)
            {
                case Actions.delete:
                    Methods.Delete(flights);
                    Console.WriteLine("");
                    break;
                case Actions.add:
                    Methods.Add(flights);
                    Console.WriteLine("");
                    break;
                case Actions.edit:
                    Methods.Edit();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Incorrect number!");
                    break;
            }




        }


    }
}
