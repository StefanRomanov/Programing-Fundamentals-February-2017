using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales_Report
{
    class SalesReport
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var salesData = new SortedDictionary<string, decimal>();

            var listSales = new List<Sales>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine()
                    .Split();

                var currentSale = new Sales()
                {
                    town = input[0],
                    product = input[1],
                    price = decimal.Parse(input[2]),
                    quantity = decimal.Parse(input[3]),
                };

                listSales.Add(currentSale);
            }

            foreach (var sale in listSales)
            {
                var town = sale.town;
                var total = sale.total;

                if (!salesData.ContainsKey(town))
                {
                    salesData.Add(town, total);
                }
                else
                {
                    salesData[town] += total;
                }
            }

            foreach (var entry in salesData)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value:f2}");
            }
        }
    }
}
