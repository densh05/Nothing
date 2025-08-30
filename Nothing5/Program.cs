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

         public double fromUahToUsd(double _uah)
        {
            return _uah / _usd;
        }
        
        public double fromUahToEur(double _uah)
        {
            return _uah / _eur;
        }

        public double fromUahToGbt(double _uah)
        {
            return _uah / _gbt;
        }

        public double fromUsdToUah(double quantityUsd)
        {
            return _usd * quantityUsd;
        }

        public double fromEurToUah(double quantityEur)
        {
            return _eur * quantityEur;
        }

        public double fromGbtToUah(double quantityGbt)
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

            double _uah = Convert.ToDouble(Console.ReadLine());

            double _usd = converter.fromUahToUsd(_uah);
            double _eur = converter.fromUahToEur(_uah);
            double _gbt = converter.fromUahToGbt(_uah);

            Console.WriteLine($"{_uah} UAH = {_usd} USD");
            Console.WriteLine($"{_uah} UAH = {_eur} EUR");
            Console.WriteLine($"{_uah} UAH = {_gbt} GBT");

            Console.WriteLine("Напишіть суму у USD для уточнення конвертації у гривні:");
            double getUsd = Convert.ToDouble(Console.ReadLine()); //Користувач вводить число,число зберігається в double usdToUah
            double usdToUah = converter.fromUsdToUah(getUsd); //Викликаємо метод fromUsdToUah з класу Converter, передаємо інформацію в метод,метод множить долари на гривні
            Console.WriteLine($"{getUsd} USD = {usdToUah} UAH"); //Вивід в консоль результат


            Console.WriteLine("Напишіть суму у EUR для уточнення конвертації у гривні:");
            double getEur = Convert.ToDouble(Console.ReadLine());
            double eurToUah = converter.fromEurToUah(getEur);
            Console.WriteLine($"{getEur} EUR = {eurToUah} UAH");

            Console.WriteLine($"Напишіть суму у GBT для уточнення конвертації у гривні:");
            double getGbt = Convert.ToDouble(Console.ReadLine());
            double gbtToUah = converter.fromGbtToUah(getGbt);
            Console.WriteLine($"{getGbt} GBT = {gbtToUah} UAH");


            Console.ReadKey();

        }
    }
}
