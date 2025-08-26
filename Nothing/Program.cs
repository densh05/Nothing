using System;

namespace Nothing
{
    class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _position;
        private int _experience;


        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void SetlInformation(string position, int experience)
        {
            _position = position;
            _experience = experience;
        }

        public double CalculateSalary()
        {
            double baseSalary;

            switch (_position)
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

            double salary = baseSalary + (baseSalary * 0.10 * _experience);
            return salary;
        }

        public double CalculateTax()
        {
          return CalculateSalary() * 0.25;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Football player {_firstName} {_lastName}");
            Console.WriteLine($"Works like {_position}");
            Console.WriteLine($"With {_experience} years experience");
            Console.WriteLine($"Get {CalculateSalary()} money");
            Console.WriteLine($"And pay {CalculateTax()} taxes");
        }
    }



     class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Lionel","Messi");

            employee.SetlInformation("Player" , 25);

            employee.ShowInformation();
        }
    }
}
