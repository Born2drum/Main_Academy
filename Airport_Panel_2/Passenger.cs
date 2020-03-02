using System;
using System.Collections.Generic;
using System.Text;

namespace Airport_Panel_2
{
    class Passenger
    {
        // public string numOfFlight;
        public int index;
        public string firstName;
        public string secondName;
        public string nationality;
        public string passport;
        public string dateOfBirthday;
        public string sex;
        public string airclass; 
        public void PassengersOutput()
        {
            Console.WriteLine($"{index,2}{firstName,15}{secondName,15}{nationality,10}  {passport,10}{dateOfBirthday,12}{sex,8}{airclass,10}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
    }
}
