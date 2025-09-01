using System;
using System.Text;

namespace Nothing5
{
    class Converter //Создання классу 
    {
        private double _usd;//Робимо змінні
        private double _eur;
        private double _gbt;

        public Converter(double usd, double eur, double gbt)//Ініціалізація змінних,робимо конструктор
        {
            _usd = usd;
            _eur = eur;
            _gbt = gbt;
        }

         public double FromUahToUsd(double amountUah)
        {
            return amountUah / _usd;
        }
        
        public double FromUahToEur(double amountUah)
        {
            return amountUah / _eur;
        }

        public double FromUahToGbt(double amountUah)
        {
            return amountUah / _gbt;
        }

        public double FromUsdToUah(double quantityUsd)
        {
            return _usd * quantityUsd;
        }

        public double FromEurToUah(double quantityEur)
        {
            return _eur * quantityEur;
        }

        public double FromGbtToUah(double quantityGbt)
        {
            return _gbt * quantityGbt;
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

            double _usd = converter.FromUahToUsd(amountUah);
            double _eur = converter.FromUahToEur(amountUah);
            double _gbt = converter.FromUahToGbt(amountUah);

            Console.WriteLine($"{amountUah} UAH = {_usd} USD");
            Console.WriteLine($"{amountUah} UAH = {_eur} EUR");
            Console.WriteLine($"{amountUah} UAH = {_gbt} GBT");

            Console.WriteLine("Напишіть суму у USD для уточнення конвертації у гривні:");
            double getUsd = Convert.ToDouble(Console.ReadLine()); //Користувач вводить число,число зберігається в double usdToUah
            double usdToUah = converter.FromUsdToUah(getUsd); //Викликаємо метод fromUsdToUah з класу Converter, передаємо інформацію в метод,метод множить долари на гривні
            Console.WriteLine($"{getUsd} USD = {usdToUah} UAH"); //Вивід в консоль результат


            Console.WriteLine("Напишіть суму у EUR для уточнення конвертації у гривні:");
            double getEur = Convert.ToDouble(Console.ReadLine());
            double eurToUah = converter.FromEurToUah(getEur);
            Console.WriteLine($"{getEur} EUR = {eurToUah} UAH");

            Console.WriteLine($"Напишіть суму у GBT для уточнення конвертації у гривні:");
            double getGbt = Convert.ToDouble(Console.ReadLine());
            double gbtToUah = converter.FromGbtToUah(getGbt);
            Console.WriteLine($"{getGbt} GBT = {gbtToUah} UAH");


            Console.ReadKey();

        }
    }
}
