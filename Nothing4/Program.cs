using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nothing4
{
    class Invoice
    {
        

        int account;
        string customer;
        string provider;

        private string _article;
        private int _quantity;

        public Invoice(int account,string customer,string provider,string article,int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            _article = article;
            _quantity = quantity;

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

            Console.WriteLine($"Користувач під номером рахунку {account},зробив замовлення в магазин {customer}");
            Console.WriteLine($"Відправник магазин техніки {provider},відправила товар {_article},у розмірі {_quantity} одиниць.");
            Console.WriteLine($"Ціна становить {CalculateWithoutTax(priceForOne)} грн за одиницю без ПДВ");
            Console.WriteLine($"Ціна з ПДВ становить {CalculateWithTax(priceForOne)} грн");
        }
    }


    internal class Program
    {
        static void Main()
        {
            Invoice invoice = new Invoice(5, "Rozetka", "Citrus", "Computer", 100);

            
            invoice.ShowInfo(35000);
        }
    }
}
