using System;

namespace Nothing
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string position;
        private int experience;


        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void JobInformation(string position, int experience)
        {
            this.position = position;
            this.experience = experience;
        }

        public double CalculateSalary()
        {
            double baseSalary;

            switch (position)
            {
                case "Player":
                    baseSalary = 10000;
                    break;
                case "Coach":
                    baseSalary = 20000;
                    break;
                case "Owner":
                    baseSalary = 300000;
                    break;
                case "Any worker":
                    baseSalary = 1000;
                    break;
                default:
                    baseSalary = 100;
                    break;
            }

            double salary = baseSalary + (baseSalary * 0.10 * experience);
            return salary;
        }

        public double CalculateTax()
        {
          return CalculateSalary() * 0.25;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Football player {firstName} {lastName}");
            Console.WriteLine($"Works like {position}");
            Console.WriteLine($"With {experience} years experience");
            Console.WriteLine($"Get {WorkerSalary()} money");
            Console.WriteLine($"And pay {TaxMoney()} taxes");
        }
    }



     class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Lionel","Messi");

            employee.Information("Player" , 25);

            employee.ShowInformation();
        }
    }
}
