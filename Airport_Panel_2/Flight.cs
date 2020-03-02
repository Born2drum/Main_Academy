using System;
using System.Collections.Generic;
using System.Text;

namespace Airport_Panel_2
{
    class Flight
    {
        public int index;
        public DateTime date;
        public int flightNumber;
        public string city;
        public string airline;
        public string terminal;
        public string status;
        public int gate;
        public List<Passenger> passengers;
        public void FlightOutput()
        {
            Console.WriteLine($"{index}{date,25}{flightNumber,10}{city,22}{airline,20}{terminal,8}{status,18}{gate,9}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

        }
    }
}
