using System;

namespace Nothing3
{
    class Information
    {

        public string Index { get; private set; }
        public string Country { get; private set; }
        public string City { get; private set; }
        public string House { get; private set; }

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
