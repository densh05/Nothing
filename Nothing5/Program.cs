using System;
using System.Text;

namespace Nothing5
{
    class Converter //Создання классу 
    {
        private readonly double Usd;//Робимо змінні
        private readonly double Eur;
        private readonly double Gbt;

        public Converter(double usd, double eur, double gbt)//Ініціалізація змінних,робимо конструктор
        {
            Usd = usd;
            Eur = eur;
            Gbt = gbt;
        }

         public double FromUahToUsd(double amountUah)
        {
            return amountUah / Usd;
        }
        
        public double FromUahToEur(double amountUah)
        {
            return amountUah / Eur;
        }

        public double FromUahToGbt(double amountUah)
        {
            return amountUah / Gbt;
        }

        public double FromUsdToUah(double amountUsd)
        {
            return Usd * amountUsd;
        }

        public double FromEurToUah(double amountEur)
        {
            return Eur * amountEur;
        }

        public double FromGbtToUah(double amountGbt)
        {
            return Gbt * amountGbt;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Converter converter = new Converter(40, 42, 45);

            Console.WriteLine("Привіт,вітаю Вас в нашому обміннику\n");
            Console.WriteLine("Напишіть суму у гривнях для уточнення інформації:");

            double amountUah = Convert.ToDouble(Console.ReadLine());

            double Usd = converter.FromUahToUsd(amountUah);
            double Eur = converter.FromUahToEur(amountUah);
            double Gbt = converter.FromUahToGbt(amountUah);

            Console.WriteLine($"{amountUah} UAH = {Usd} USD");
            Console.WriteLine($"{amountUah} UAH = {Eur} EUR");
            Console.WriteLine($"{amountUah} UAH = {Gbt} GBT");

            Console.WriteLine("Напишіть суму у USD для уточнення конвертації у гривні:");
            double getUserUsd = Convert.ToDouble(Console.ReadLine()); //Користувач вводить число,число зберігається в double usdToUah
            double usdToUah = converter.FromUsdToUah(getUserUsd); //Викликаємо метод fromUsdToUah з класу Converter, передаємо інформацію в метод,метод множить долари на гривні
            Console.WriteLine($"{getUserUsd} USD = {usdToUah} UAH"); //Вивід в консоль результат


            Console.WriteLine("Напишіть суму у EUR для уточнення конвертації у гривні:");
            double getUserEur = Convert.ToDouble(Console.ReadLine());
            double eurToUah = converter.FromEurToUah(getUserEur);
            Console.WriteLine($"{getUserEur} EUR = {eurToUah} UAH");

            Console.WriteLine($"Напишіть суму у GBT для уточнення конвертації у гривні:");
            double getUserGbt = Convert.ToDouble(Console.ReadLine());
            double gbtToUah = converter.FromGbtToUah(getUserGbt);
            Console.WriteLine($"{getUserGbt} GBT = {gbtToUah} UAH");


            Console.ReadKey();

        }
    }
}
