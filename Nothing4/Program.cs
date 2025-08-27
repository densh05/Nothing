using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nothing4
{
    class Invoice
    {
        

       private readonly int _account;
       private readonly string _customer;
       private readonly string _provider;

        private string _article;
        private int _quantity;

        public Invoice(int account,string customer,string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;

        }

        public void SetInformation(string _article,int _quantity)
        {
            this._article = _article;
            this._quantity = _quantity;

        }

        public double CalculateWithoutTax(double priceForOne)
        {
            return _quantity * priceForOne;
        }

        public double CalculateWithTax(double priceForOne)
        {
            double sum = CalculateWithoutTax(priceForOne);
            return sum * 1.2;
        }

        public void ShowInfo(double priceForOne)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"Користувач під номером рахунку {_account},зробив замовлення в магазин {_customer}");
            Console.WriteLine($"Відправник магазин техніки {_provider},відправила товар {_article},у розмірі {_quantity} одиниць.");
            Console.WriteLine($"Ціна становить {CalculateWithoutTax(priceForOne)} грн за одиницю без ПДВ");
            Console.WriteLine($"Ціна з ПДВ становить {CalculateWithTax(priceForOne)} грн");
        }
    }


    internal class Program
    {
        static void Main()
        {
            Invoice invoice = new Invoice(5, "Rozetka", "Citrus");

            invoice.SetInformation("Computer", 15);

            
            invoice.ShowInfo(35000);
        }
    }
}
