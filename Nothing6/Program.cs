using System;
using System.Text;

namespace Nothing6
{
   class User
    {
        public int Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public User(int login,string name,string surname,int age) 
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;

        }

        public void Show()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Користувача з логіном {Login}");
            Console.WriteLine($"Звуть {Name}");
            Console.WriteLine($"Прізвище {Surname}");
            Console.WriteLine($"Років {Age}");
        }


    }

       

        
    

    internal class Program
    {
        static void Main()
        {
            User user = new User(123,"Denys","Shaitan",23);
            user.Show();

        }
    }
}
