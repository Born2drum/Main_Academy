using System;
using System.Collections.Generic;

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
            Console.WriteLine($"{index}{date,25}{flightNumber,10}{city,22}{airline,20}{terminal,8}{status,18}{gate,9}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

        }
    }
    public enum Actions
    {
        delete = 1,
        add,
        edit,
        search,
        exit
    };
    public enum SearchE
    {
        byNum = 1,
        byTime,
        byCity
    };



    static class Methods
    {
        public static void Delete(List<Flight> flights)
        {

            Console.WriteLine("Enter the index of the element which you want to delete: ");
            int del;
            del = int.Parse(Console.ReadLine());
            if (del > 0 && del <= flights.Count)
            {
                flights.Remove(flights[del-1]);
                for(int i=0; i< flights.Count; i++)
                {
                    flights[i].index = i+1;
                }
                Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].Output();
                }
            }
            else
            {
                Console.WriteLine("Inncorect index");
            }
            Menu();
        }



        public static void Add(List<Flight> flights)
        {

            Console.WriteLine("Enter on which position you want to add a new element: ");
            int n;
            n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= flights.Count)
            {
                flights.Insert(n-1, new Flight());
                flights[n - 1].index = n;
                Console.WriteLine("Enter date(дд.мм.рррр гг:хх:сс): ");
                string d = Console.ReadLine();
                if (DateTime.TryParse(d,out DateTime da)) {
                    flights[n - 1].date = DateTime.Parse(d);
                }
                else{
                    Console.WriteLine("Incorrect date, try again");
                    Add(flights);
                }
                Console.WriteLine("Enter number of flight: ");
                string fl = Console.ReadLine();
                if (Int32.TryParse(fl,out int x)&&int.Parse(fl)<150 && int.Parse(fl)>0) {
                    flights[n - 1].flightNumber = int.Parse(fl);
                }
                else
                {
                    Console.WriteLine("Incorrect number, try again");
                    Add(flights);
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
                    Add(flights);
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
                    Add(flights);
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
                    Add(flights);
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
                    Add(flights);
                }
                Console.WriteLine("Enter gates: ");
                string ga = Console.ReadLine();
                if (Int32.TryParse(ga, out int v) && int.Parse(ga) < 100 && int.Parse(ga)>0)
                {
                    flights[n - 1].gate = int.Parse(ga);
                }
                else
                {
                    Console.WriteLine("Incorrect gate, try again");
                    Add(flights);
                }
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].index = i + 1;
                }
                Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].Output();
                }
            }
            else
            {
                Console.WriteLine("Inncorect index");
            }
            Menu();
        }



        public static void Edit(List<Flight> flights)
        {
            Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].Output();
            }
            Console.WriteLine("Enter the index of the element which you want to edit");
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
                    Add(flights);
                }
                Console.WriteLine("Enter new number of flight: ");
                string fl = Console.ReadLine();
                if (Int32.TryParse(fl, out int x) && int.Parse(fl) < 150 && int.Parse(fl)>0)
                {
                    flights[dc].flightNumber = int.Parse(fl);
                }
                else
                {
                    Console.WriteLine("Incorrect number, try again");
                    Add(flights);
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
                    Add(flights);
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
                    Add(flights);
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
                    Add(flights);
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
                    Add(flights);
                }
                Console.WriteLine("Enter new gates: ");
                string ga = Console.ReadLine();
                if (Int32.TryParse(ga, out int v) && int.Parse(ga) < 100 && int.Parse(ga)>0)
                {
                    flights[dc].gate = int.Parse(ga);
                }
                else
                {
                    Console.WriteLine("Incorrect gate, try again");
                    Add(flights);
                }
                
                /*Console.WriteLine("Enter new date:");
                flights[d].date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter new number of flight:");
                flights[d].flightNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new city:");
                flights[d].city = Console.ReadLine();
                Console.WriteLine("Enter new airline:");
                flights[d].airline = Console.ReadLine();
                Console.WriteLine("Enter new terminal:");
                flights[d].terminal = Console.ReadLine();
                Console.WriteLine("Enter new status:");
                flights[d].status = Console.ReadLine();
                Console.WriteLine("Enter new gate:");
                flights[d].gate = int.Parse(Console.ReadLine());*/
                Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
                for (int i = 0; i < flights.Count; i++)
                {
                    flights[i].Output();
                }
            }
            else
            {
                Console.WriteLine("Inncorect index");
            }
            Menu();
        }



        public static void Menu()
        {
            Console.WriteLine(@"Type a number:
                        1.Delete 
                        2.Add
                        3.Edit
                        4.Search
                        5.Exit menu");


        }


       /* delegate void Search(List<Flight> flights);
        Search srch = SearchByNum;*/
        public static void SearchByNum(List <Flight> flights)
        {
            Console.WriteLine("Enter number of necessary flight");
            int num = int.Parse(Console.ReadLine());
            for(int i =0; i<flights.Count; i++)
            {
                if (flights[i].flightNumber == num)
                {
                    flights[i].Output();
                    return;
                }

            }
            Console.WriteLine("Flight with this number is not found");
        }
        public static void SearchByTime(List<Flight> flights)
        {
            Console.WriteLine("Enter number of necessary flight");
            DateTime time = DateTime.Parse(Console.ReadLine());
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].date == time)
                {
                    flights[i].Output();
                }
                else
                {
                    Console.WriteLine("Flight with this time is not found");
                }
            }
        }
        public static void SearchByCity(List<Flight> flights)
        {
            Console.WriteLine("Enter number of necessary flight");
            string city = Console.ReadLine();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].city == city)
                {
                    flights[i].Output();
                }
                else
                {
                    Console.WriteLine("Flight with this city is not found");
                }
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Random rnd = new Random();
            string[] cities = { "Kyiv", "Boryspil", "Viena", "Los Angeles", "Moskow", "Minsk", "Warsaw" };
            string[] airlines = { "7up", "MAU", "Turkish Airlines", "Emirates", "Ryanair", "Wizz Air" };
            int[] flightNumbers = new int[10];
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                flightNumbers[i] = rnd.Next(50);
            }
            string[] terminals = { "D1", "D2", "D3", "D4" };
            string[] statuses = { "checkIn", "gateClosed", "arrived", "departed", "unknown", "canceled", "expected", "delayed", "inFlight" };
            int[] gates = new int[10];

            for (int i = 0; i < gates.Length; i++)
            {
                gates[i] = rnd.Next(50);
            }

            DateTime date = DateTime.Now;
            List<Flight> flights = new List<Flight>();
            for (int i = 1; i <= n; i++)
            {
                flights.Add(new Flight());
                flights[i-1].index = i;
                flights[i-1].date = date + TimeSpan.FromHours(2.0);              
                flights[i-1].city = cities[rnd.Next(0, cities.Length)];
                flights[i-1].flightNumber = flightNumbers[rnd.Next(0, flightNumbers.Length)];
                flights[i-1].airline = airlines[rnd.Next(0, airlines.Length)];
                flights[i-1].terminal = terminals[rnd.Next(0, terminals.Length)];
                flights[i-1].status = statuses[rnd.Next(0, statuses.Length)];
                flights[i-1].gate = gates[rnd.Next(0, gates.Length)];
                date += TimeSpan.FromHours(2.0);
            }
            Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].Output();
            }
            Actions ac;
            Methods.Menu();
            do
            {
                ac = (Actions)Enum.Parse(typeof(Actions), Console.ReadLine());
                if (ac > 0 && (int)ac < 5)
                {
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
                            Methods.Edit(flights);
                            Console.WriteLine("");
                            break;
                        case Actions.search:
                            Console.WriteLine(@"Choose how to search:
                                                       1.By number
                                                       2.By time 
                                                       3.By city");
                            SearchE sch;
                            sch = (SearchE)Enum.Parse(typeof(Actions), Console.ReadLine());
                            if (sch > 0 && (int)sch < 4)
                            {
                                switch (sch)
                                {
                                    case SearchE.byNum:
                                        Methods.SearchByNum(flights);
                                        break;
                                    case SearchE.byTime:
                                        Methods.SearchByTime(flights);
                                        break;
                                    case SearchE.byCity:
                                        Methods.SearchByCity(flights);
                                        break;
                                }
                                Methods.Menu();
                            }
                            break;
                        case Actions.exit:
                            break;

                        default:
                            Console.WriteLine("Incorrect number!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect number, try again");
                    Methods.Menu();
                }
            } while (ac != Actions.exit);

        }
    }
}
