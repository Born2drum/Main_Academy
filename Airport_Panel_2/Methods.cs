using System;
using System.Collections.Generic;
using System.Text;

namespace Airport_Panel_2
{
    static class Methods
    {
        public static void FlightDelete(List<Flight> flights)
        {

            Console.WriteLine("Enter the index of the element which you want to FlightDelete: ");
            int del;
            del = int.Parse(Console.ReadLine());
            if (del > 0 && del <= flights.Count)
            {
                flights.Remove(flights[del - 1]);
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].index = i + 1;
                }
                Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].FlightOutput();
                }
            }
            else
            {
                Console.WriteLine("Inncorect index");
            }
            Menu();
        }



        public static void FlightAdd(List<Flight> flights)
        {

            Console.WriteLine("Enter on which position you want to FlightAdd a new element: ");
            int n;
            n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= flights.Count)
            {
                flights.Insert(n - 1, new Flight());
                flights[n - 1].index = n;
                Console.WriteLine("Enter date(дд.мм.рррр гг:хх:сс): ");
                string d = Console.ReadLine();
                if (DateTime.TryParse(d, out DateTime da))
                {
                    flights[n - 1].date = DateTime.Parse(d);
                }
                else
                {
                    Console.WriteLine("Incorrect date, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter number of flight: ");
                string fl = Console.ReadLine();
                if (Int32.TryParse(fl, out int x) && int.Parse(fl) < 150 && int.Parse(fl) > 0)
                {
                    flights[n - 1].flightNumber = int.Parse(fl);
                }
                else
                {
                    Console.WriteLine("Incorrect number, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter  city: ");
                string c = Console.ReadLine();
                if (c.Length > 0 && c.Length < 15)
                {
                    flights[n - 1].city = c;
                }
                else
                {
                    Console.WriteLine("Incorrect city, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter airline: ");
                string air = Console.ReadLine();
                if (air.Length > 0 && air.Length < 20)
                {
                    flights[n - 1].airline = air;
                }
                else
                {
                    Console.WriteLine("Incorrect airline, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter terminal: ");
                string ter = Console.ReadLine();
                if (ter.Length > 0 && ter.Length < 5)
                {
                    flights[n - 1].terminal = ter;
                }
                else
                {
                    Console.WriteLine("Incorrect terminal, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter status: ");
                string st = Console.ReadLine();
                if (st.Length > 0 && st.Length < 20)
                {
                    flights[n - 1].status = st;
                }
                else
                {
                    Console.WriteLine("Incorrect status, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter gates: ");
                string ga = Console.ReadLine();
                if (Int32.TryParse(ga, out int v) && int.Parse(ga) < 100 && int.Parse(ga) > 0)
                {
                    flights[n - 1].gate = int.Parse(ga);
                }
                else
                {
                    Console.WriteLine("Incorrect gate, try again");
                    FlightAdd(flights);
                }
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].index = i + 1;
                }
                Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].FlightOutput();
                }
            }
            else
            {
                Console.WriteLine("Inncorect index");
            }
            Menu();
        }



        public static void FlightEdit(List<Flight> flights)
        {
            Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].FlightOutput();
            }
            Console.WriteLine("Enter the index of the element which you want to FlightEdit");
            int dc = int.Parse(Console.ReadLine());
            if (dc > 0 && dc <= flights.Count)
            {
                flights[dc].index = dc;
                Console.WriteLine("Enter new date(дд.мм.рррр гг:хх:сс): ");
                string d = Console.ReadLine();
                if (DateTime.TryParse(d, out DateTime da))
                {
                    flights[dc].date = DateTime.Parse(d);
                }
                else
                {
                    Console.WriteLine("Incorrect date, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter new number of flight: ");
                string fl = Console.ReadLine();
                if (Int32.TryParse(fl, out int x) && int.Parse(fl) < 150 && int.Parse(fl) > 0)
                {
                    flights[dc].flightNumber = int.Parse(fl);
                }
                else
                {
                    Console.WriteLine("Incorrect number, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter new city: ");
                string c = Console.ReadLine();
                if (c.Length > 0 && c.Length < 15)
                {
                    flights[dc].city = c;
                }
                else
                {
                    Console.WriteLine("Incorrect city, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter new airline: ");
                string air = Console.ReadLine();
                if (air.Length > 0 && air.Length < 20)
                {
                    flights[dc].airline = air;
                }
                else
                {
                    Console.WriteLine("Incorrect airline, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter new terminal: ");
                string ter = Console.ReadLine();
                if (ter.Length > 0 && ter.Length < 5)
                {
                    flights[dc].terminal = ter;
                }
                else
                {
                    Console.WriteLine("Incorrect terminal, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter new status: ");
                string st = Console.ReadLine();
                if (st.Length > 0 && st.Length < 20)
                {
                    flights[dc].status = st;
                }
                else
                {
                    Console.WriteLine("Incorrect status, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine("Enter new gates: ");
                string ga = Console.ReadLine();
                if (Int32.TryParse(ga, out int v) && int.Parse(ga) < 100 && int.Parse(ga) > 0)
                {
                    flights[dc].gate = int.Parse(ga);
                }
                else
                {
                    Console.WriteLine("Incorrect gate, try again");
                    FlightAdd(flights);
                }
                Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].FlightOutput();
                }
            }
            else
            {
                Console.WriteLine("Inncorect index");
            }
            Menu();
        }

        /*public static void PassengerDelete(List<Passenger> passengers)
        {
            int del;
            del = int.Parse(Console.ReadLine());
            if (del > 0 && del <= passengers.Count)
            {
                passengers.Remove(passengers[del - 1]);
                for (int i = 0; i < passengers.Count; i++)
                {
                    passengers[i].index = i + 1;
                }
                Console.WriteLine("\r\nindex: First Name: Second Name: Nationality: Passport:    Date:     Sex:  Airclass: \r\n");
                for (int i = 0; i < passengers.Count; i++)
                {
                    passengers[i].PassengersOutput();
                }
            }
            else
            {
                Console.WriteLine("Inncorect index");
            }
            Menu();
        }*/



        public static void Menu()
        {
            Console.WriteLine(@"Type a number:
                        1.FlightDelete 
                        2.FlightAdd
                        3.FlightEdit
                        4.Search
                        5.Passenger delete
                        5.Exit menu");


        }


        /* delegate void Search(List<Flight> flights);
         Search srch = SearchByNum;*/
        public static void SearchByNum(List<Flight> flights)
        {
            Console.WriteLine("Enter number of necessary flight");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].flightNumber == num)
                {
                    Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                    flights[i].FlightOutput();
                    Console.WriteLine("\r\nindex: First Name: Second Name: Nationality: Passport:    Date:     Sex:  Airclass: \r\n");
                    for (int j = 0; j < flights[i].passengers.Count; j++)
                    {
                        
                        flights[i].passengers[j].PassengersOutput();
                    }
                    
                    return; 
                }

            }
            Console.WriteLine("Flight with this number is not found");
        }
        public static void SearchByTime(List<Flight> flights)
        {
            Console.WriteLine("Enter time of necessary flight");
            DateTime time = DateTime.Parse(Console.ReadLine());
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].date == time)
                {
                    Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                    flights[i].FlightOutput();
                }
            }
            Console.WriteLine("Flight with this time is not found");
        }
        public static void SearchByCity(List<Flight> flights)
        {
            Console.WriteLine("Enter city of necessary flight");
            string city = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].city == city)
                {
                    Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                    flights[i].FlightOutput();
                }
            }
            Console.WriteLine("Flight with this city is not found");
        }
    }
}
