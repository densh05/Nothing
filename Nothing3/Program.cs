using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Nothing3
{

    class Employee
    {
        private string firstname;
        private string lastname;
        private int experience;
        private string position;

        public Employee(string firstname,string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public void Information(int experience,string position)
        {
            this.experience = experience;
            this.position = position;
        }

        public double Money()
        {
            double normalSalary;

            switch(position)
            {
                case "Футболіст":
                    normalSalary = 15000;
                    break;

                case "Тренер":
                    normalSalary = 20000;
                    break;

                case "Власник":
                    normalSalary = 100000;
                    break;

                default:
                    Console.WriteLine("Працівник клубу");
                    normalSalary = 5000;
                    break;


            }

            double salary = normalSalary + (normalSalary * 0.10 * experience);
            return salary;

        }



        public double Tax()
        {
            return Money() * 0.47;
        }

        public void ShowInformation()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Гравець:{ firstname} {lastname }");
            Console.WriteLine($"Грає у футбол {experience} років");
            Console.WriteLine($"Має зарплатню {Money()} грн");
            Console.WriteLine($"Та платить податок {Tax()} грн");
        }

    }
   

    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Андрій" , "Ярмоленко" );

            employee.Information(20, "Футболіст");

            employee.ShowInformation();

        }

    }

}
