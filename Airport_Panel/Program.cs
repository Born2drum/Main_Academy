using System;
using System.Collections.Generic;

namespace Airport_Panel
{
    class Flight
    {
        public DateTime date;
        public int number;
        public string city;
        public string airline;
        public string terminal;
        public static string[] Status = new string[9]
        {
            "checkIn",
            "gateClosed",
            "arrived",
            "departed",
            "unknown",
            "canceled",
            "expected",
            "delayed",
            "inFlight"
        };
        public string status;

        public string gate;
        public Flight(DateTime date, int number, string city, string airline, string terminal, string gate)
        {
            this.date = date;
            this.number = number;
            this.city = city;
            this.airline = airline;
            this.terminal = terminal;
            this.status = Status[new Random().Next(0, Status.Length)]; ;
            this.gate = gate;

        }
        public void Output()
        {
            Console.WriteLine($" date of arrival: {date} number of flight: {number} city: {city} airline: {airline} terminal: {terminal}  gate: {gate} ");
     
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2019, 5, 13);
            Flight flight1 = new Flight(date, 312, "Kyiv", "MAU", "B1", "G13");
            Flight flight2 = new Flight(date, 442, "Boryspil", "7days", "B1", "G5");
            Flight flight3 = new Flight(date, 218, "Lviv", "Turkish airlines", "B2", "G8");
            Flight flight4 = new Flight(date, 125, "Odessa", "Fly emirates", "B3", "G25");
            List<Flight> flights = new List<Flight>(){
              flight1,
              flight2,
              flight3,
              flight4
            };
            for(int i = 0; i<flights.Count; i++)
            {
                flights[i].Output();
            }
        }
    }
   
}
