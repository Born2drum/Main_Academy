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
            if (del > 0 && del < flights.Count)
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
            n = int.Parse(Console.ReadLine()) - 1;
            if (n > 0 && n <= flights.Count)
            {
                flights.Insert(n, new Flight());
                flights[n].index = n;
                Console.WriteLine("Enter date(дд.мм.рррр гг:хх:сс): ");
                string d = Console.ReadLine();
                if (DateTime.TryParse(d, out DateTime da))
                {
                    flights[n].date = DateTime.Parse(d);
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
                    flights[n].flightNumber = int.Parse(fl);
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
                    flights[n].city = c;
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
                    flights[n].airline = air;
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
                    flights[n].terminal = ter;
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
                    flights[n].status = st;
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
                    flights[n].gate = int.Parse(ga);
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

        public static void PassengerDelete(List<Flight> flights)
        {

            Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].FlightOutput();
            }
            Console.WriteLine("Choose flight:");
            int f = int.Parse(Console.ReadLine());
            if (f > 0 && f < flights.Count)
            {
                flights[f - 1].FlightOutput();
                for (int i = 0; i < flights[f - 1].passengers.Count; i++)
                {
                    flights[f - 1].passengers[i].PassengersOutput();
                }
                Console.WriteLine("Enter index of passenger who you want to delete:");
                int del = int.Parse(Console.ReadLine());
                if (del > 0 && del < flights[f - 1].passengers.Count)
                {
                    flights[f - 1].passengers.Remove(flights[f - 1].passengers[del - 1]);
                    for (int i = 0; i < flights[f - 1].passengers.Count; i++)
                    {
                        flights[f - 1].passengers[i].index = i + 1;
                    }
                    Console.WriteLine("\r\nindex: First Name: Second Name: Nationality: Passport:    Date:     Sex:  Airclass: \r\n");
                    for (int i = 0; i < flights[f - 1].passengers.Count; i++)
                    {
                        flights[f - 1].passengers[i].PassengersOutput();
                    }
                }
                else
                {
                    Console.WriteLine("Inncorect index");
                }

            }
            else
            {
                Console.WriteLine("Inncorect index of flight");
            }
            Menu();
        }

        public static void PassengerEdit(List<Flight> flights)
        {
            Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].FlightOutput();
            }
            Console.WriteLine("Choose flight:");
            int f = int.Parse(Console.ReadLine()) - 1;
            if (f > 0 && f < flights.Count)
            {
                flights[f].FlightOutput();
                for (int i = 0; i < flights[f].passengers.Count; i++)
                {
                    flights[f].passengers[i].PassengersOutput();
                }
                Console.WriteLine("Enter index of passenger who you want to edit:");
                int change = int.Parse(Console.ReadLine()) - 1;

                if (change > 0 && change < flights[f].passengers.Count)
                {
                    flights[f].passengers[change].index = change;
                    Console.WriteLine("Enter new first name:");
                    string first = Console.ReadLine();
                    if (first.Length < 10)
                    {
                        flights[f].passengers[change].firstName = first;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerEdit(flights);
                    }
                    Console.WriteLine("Enter new second name:");
                    string second = Console.ReadLine();
                    if (second.Length < 20)
                    {
                        flights[f].passengers[change].secondName = second;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerEdit(flights);
                    }
                    Console.WriteLine("Enter new nationality:");
                    string nationality = Console.ReadLine();
                    if (nationality.Length < 20)
                    {
                        flights[f].passengers[change].nationality = nationality;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerEdit(flights);
                    }
                    Console.WriteLine("Enter new  passport:");
                    string passport = Console.ReadLine();
                    if (passport.Length < 10)
                    {
                        flights[f].passengers[change].passport = passport;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerEdit(flights);
                    }
                    Console.WriteLine("Enter new date of birthday(dd.mm.YYYY:");
                    string date = Console.ReadLine();
                    if (date.Length < 11)
                    {
                        flights[f].passengers[change].dateOfBirthday = date;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerEdit(flights);
                    }
                    Console.WriteLine("Enter new sex:");
                    string sex = Console.ReadLine();
                    if (sex.Length < 12)
                    {
                        flights[f].passengers[change].sex = sex;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                    }
                    Console.WriteLine("Enter new airclass:");
                    string airclass = Console.ReadLine();
                    if (airclass.Length < 10)
                    {
                        flights[f].passengers[change].airclass = airclass;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                    }
                    for (int i = 0; i < flights[f].passengers.Count; i++)
                    {
                        flights[f].passengers[i].index = i + 1;
                    }
                    flights[f].FlightOutput();
                    Console.WriteLine("\r\nindex: First Name: Second Name: Nationality: Passport:    Date:     Sex:  Airclass: \r\n");
                    for (int i = 0; i < flights[f].passengers.Count; i++)
                    {
                        flights[f].passengers[i].PassengersOutput();
                    }

                }
            }
            Menu();
        }




        public static void PassengerAdd(List<Flight> flights)
        {
            Console.WriteLine($"index:  date of arrival:       number of flight:       city:       airline:       terminal:       status:       gate:\r\n\r\n");
            for (int i = 0; i < flights.Count; i++)
            {
                flights[i].FlightOutput();
            }
            Console.WriteLine("Choose flight:");
            int f = int.Parse(Console.ReadLine()) - 1;
            if (f > 0 && f < flights.Count)
            {
                Console.WriteLine("Enter on which position do you want to add a passenger:");
                int add = int.Parse(Console.ReadLine()) - 1;
                if (add > 0 && add < flights[f].passengers.Count)
                {
                    flights[f].passengers.Insert(add, new Passenger());
                    flights[f].passengers[add].index = add;
                    Console.WriteLine("Enter new first name:");
                    string first = Console.ReadLine();
                    if (first.Length < 10)
                    {
                        flights[f].passengers[add].firstName = first;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerAdd(flights);
                    }
                    Console.WriteLine("Enter new second name:");
                    string second = Console.ReadLine();
                    if (second.Length < 20)
                    {
                        flights[f].passengers[add].secondName = second;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerAdd(flights);
                    }
                    Console.WriteLine("Enter new nationality:");
                    string nationality = Console.ReadLine();
                    if (nationality.Length < 20)
                    {
                        flights[f].passengers[add].nationality = nationality;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerAdd(flights);
                    }
                    Console.WriteLine("Enter new  passport:");
                    string passport = Console.ReadLine();
                    if (passport.Length < 10)
                    {
                        flights[f].passengers[add].passport = passport;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerAdd(flights);
                    }
                    Console.WriteLine("Enter new date of birthday(dd.mm.YYYY:");
                    string date = Console.ReadLine();
                    if (date.Length < 11)
                    {
                        flights[f].passengers[add].dateOfBirthday = date;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                        PassengerAdd(flights);
                    }
                    Console.WriteLine("Enter new sex:");
                    string sex = Console.ReadLine();
                    if (sex.Length < 12)
                    {
                        flights[f].passengers[add].sex = sex;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                    }
                    Console.WriteLine("Enter new airclass:");
                    string airclass = Console.ReadLine();
                    if (airclass.Length < 10)
                    {
                        flights[f].passengers[add].airclass = airclass;
                    }
                    else
                    {
                        Console.WriteLine("Too much symbols! Try again!");
                    }
                }
                for (int i = 0; i < flights[f].passengers.Count; i++)
                {
                    flights[f].passengers[i].index = i + 1;
                }
                Console.WriteLine("\r\nindex: First Name: Second Name: Nationality: Passport:    Date:     Sex:  Airclass: \r\n");
                for (int i = 0; i < flights[f].passengers.Count; i++)
                {
                    flights[f].passengers[i].PassengersOutput();
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
                        1.Flight delete 
                        2.Flight add
                        3.Flight edit
                        4.Search
                        5.Passenger delete
                        6.Passenger add
                        7.Passenger edit
                        8.Exit menu");


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
