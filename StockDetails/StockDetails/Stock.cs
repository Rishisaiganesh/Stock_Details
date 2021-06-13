using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace StockDetails
{
    public class Stock
    {
        private int totalPriceOfStock;

        public void Check()
        {
            int valueOfStock;
            int totalpriceOfStock = 0;
            var json = File.ReadAllText(@"C:\Users\naren\source\StockDetails\StockDetails\StockDetails\json1.json ");
            var jObject = JObject.Parse(json);
            var StockAccountarray = (JArray)jObject["StockAccount"];
            if (jObject != null)
            {
                Console.WriteLine("StockName   NumberofShares   SharePrice   ValueofStock");
                foreach (var iteam in StockAccountarray)
                {
                    valueOfStock = StockPrice(iteam["NumOfShares"], iteam["SharePrice"]);
                    totalPriceOfStock += valueOfStock;
                    Console.WriteLine(iteam["StockName"] + "    " + iteam["NumOfShares"] + "      " + iteam["SharePrice"] + "     " + valueOfStock);
                    Console.WriteLine("total value" + totalpriceOfStock);
                }
            }
        }

        public int StockPrice(JToken NumOfShares, JToken SharePrice)
        {
            int shares = NumOfShares.ToObject<int>();
            int price = SharePrice.ToObject<int>();
            int valueOfStock = 0;

            valueOfStock = shares * price;

            return valueOfStock;

        }
    }
}
