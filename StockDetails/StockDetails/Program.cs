using System;

namespace StockDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to StockAccounts Details");
            Stock stock = new Stock();
            stock.Check();
            
        }
    }
}
