using System;

namespace Nothing3
{
    class Information
    {
        private string index;
        private string country;
        private string city;
        private string house;

        public string Index { get { return index; } private set { index = value; } }
        public string Country { get { return country; } private set { country = value; } }
        public string City { get { return city; } private set { city = value; } }
        public string House { get { return house; } private set { house = value; } }

        public Information(string index, string country, string city, string house)
        {
            Index = index;
            Country = country;
            City = city;
            House = house;
        }

    }

    class Program
    {
        static void Main()
        {
            Information information = new Information(
                "2000",
                "Denmark",
                "Copenhagen",
                "20");

            Console.WriteLine(information.Index);
            Console.WriteLine(information.Country);
            Console.WriteLine(information.City);
            Console.WriteLine(information.House);

            Console.ReadKey();
        }

    }

}
