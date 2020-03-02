using System;
using System.Collections.Generic;

namespace Airport_Panel_2
{
    public enum Actions
    {
        FlightDelete = 1,
        FlightAdd,
        FlightEdit,
        search,
        PassengerDelete,
        PassengerAdd,
        PassengerEdit,
        exit
    };
    public enum SearchE
    {
        byNum = 1,
        byTime,
        byCity
    };

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // about passengers 
            string[] firstNames = { "Yuriy", "Vasya", "Vlad", "Kiril", "Julia", "Nastya", "Kate", "Bob", "Jack", "Artem", "Diana", "Lera", "Anya" };
            string[] secondNames = { "Kosenko", "Pavlenko", "Kotlarenko", "Kharchenko", "Polishchuk", "Rudenko", "Fesenko", "Lazarenko", "Osadchyi", "Marynenko", "Komendant", "Poshukailo", "Savchenko" };
            string[] nationalities = { "Ukranian", "Pole", "German", "British", "Slovak", "Italian", "Russian" };
            string[] passports = new string[13];
            for (int i = 0; i < firstNames.Length; i++)
            {
                int a = rnd.Next(000000, 999999);
                string b = "";
                for (int j = 0; j < 2; j++)
                {
                    b += (char)(rnd.Next(1040, 1071));
                }
                passports[i] = b + a;
                //Console.WriteLine(passports[i]);
            }
            string[] datesOfBirthday = new string[13];
            for (int i = 0; i < firstNames.Length; i++)
            {
                int a = rnd.Next(01, 31);
                int b = rnd.Next(01, 12);
                int c = rnd.Next(1950, 2019);
                datesOfBirthday[i] = String.Format($"{a}.{b}.{c}");
                //Console.WriteLine(datesOfBirthday[i]);
            }
            string[] sexs = { "male", "female" };
            string[] airclasses = { "economy", "busines" };




            int n = 5;
           
            string[] cities = { "Kyiv", "Boryspil", "Viena", "Los Angeles", "Moskow", "Minsk", "Warsaw" };
            string[] airlines = { "7up", "MAU", "Turkish Airlines", "Emirates", "Ryanair", "Wizz Air" };
            int[] flightNumbers = new int[10];
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                flightNumbers[i] = rnd.Next(1,50);
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
            for (int i = 0; i <= n; i++)
            {
                List<Passenger> passengers = new List<Passenger>();
                flights.Add(new Flight());
                flights[i].index = i+1;
                flights[i].date = date + TimeSpan.FromHours(2.0);
                flights[i].city = cities[rnd.Next(0, cities.Length)];
                flights[i].flightNumber = flightNumbers[rnd.Next(0, flightNumbers.Length)];
                flights[i].airline = airlines[rnd.Next(0, airlines.Length)];
                flights[i].terminal = terminals[rnd.Next(0, terminals.Length)];
                flights[i].status = statuses[rnd.Next(0, statuses.Length)];
                flights[i].gate = gates[rnd.Next(0, gates.Length)];
                flights[i].passengers = passengers;
                date += TimeSpan.FromHours(2.0);
                for (int j = 0; j <= firstNames.Length; j++)
                {

                    passengers.Add(new Passenger());
                    passengers[j].index = j+1;
                    passengers[j].firstName = firstNames[rnd.Next(0, firstNames.Length)];
                    passengers[j].secondName = secondNames[rnd.Next(0, secondNames.Length)];
                    passengers[j].nationality = nationalities[rnd.Next(0, nationalities.Length)];
                    passengers[j].passport = passports[rnd.Next(0, passports.Length)];
                    passengers[j].dateOfBirthday = datesOfBirthday[rnd.Next(0, datesOfBirthday.Length)];
                    passengers[j].sex = sexs[rnd.Next(0, sexs.Length)];
                    passengers[j].airclass = airclasses[rnd.Next(0, airclasses.Length)];
                }
            }
            Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].FlightOutput();
            }

            


            Actions ac;
            Methods.Menu();
            do
            {
                ac = (Actions)Enum.Parse(typeof(Actions), Console.ReadLine());
                if (ac > 0 && (int)ac <9)
                {
                    switch (ac)
                    {
                        case Actions.FlightDelete:
                            Methods.FlightDelete(flights);
                            Console.WriteLine("");
                            break;
                        case Actions.FlightAdd:
                            Methods.FlightAdd(flights);
                            Console.WriteLine("");
                            break;
                        case Actions.FlightEdit:
                            Methods.FlightEdit(flights);
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
                        case Actions.PassengerDelete:
                            Methods.PassengerDelete(flights);
                            break;
                        case Actions.PassengerAdd:
                            Methods.PassengerAdd(flights);
                            break;
                        case Actions.PassengerEdit:
                            Methods.PassengerEdit(flights);
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
