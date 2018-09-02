using System;
using System.Collections.Generic;
using System.Linq;

namespace Andrey_Billard
{
    class AndreyBillard
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var clients = new List<Client>();

            var priceList = new Dictionary<string, decimal>();

            for (int i = 0; i < number; i++)
            {
                var data = Console.ReadLine().Split('-').ToArray();
                var product = data[0];
                var price = decimal.Parse(data[1]);

                if (!priceList.ContainsKey(product))
                {
                    priceList.Add(product, price);
                }

                priceList[product] = price;
            }

            var order = Console.ReadLine();

            while (order != "end of clients")
            {
                var orderData = order
                    .Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var clientName = orderData[0];
                var orderedProduct = orderData[1];
                var quantity = int.Parse(orderData[2]);

                if (priceList.ContainsKey(orderedProduct))
                {
                    if (!clients.Exists(x => x.Name == clientName))
                    {
                        var client = new Client()
                        {
                            Name = clientName,
                            ShopList = new Dictionary<string, int>(),
                        };

                            client.ShopList.Add(orderedProduct, quantity);
                            clients.Add(client);
                    }
                    else
                    {
                        var currentClient = clients.Single(x => x.Name == clientName);

                        if (!currentClient.ShopList.ContainsKey(orderedProduct))
                        {
                            currentClient.ShopList.Add(orderedProduct, quantity);
                        }
                        else
                        {
                            currentClient.ShopList[orderedProduct] += quantity;
                        }
                    }
                }

                clients = clients
                    .OrderBy(x => x.Name)
                    .ToList();

                order = Console.ReadLine();
            }

            foreach (var client in clients) //calculate bills
            {
                foreach (var entry in client.ShopList)
                {
                    var quantity = entry.Value;
                    var price = priceList[entry.Key];

                    client.Bill += quantity * price;
                }
            }

            var billTotal = clients.Sum(x => x.Bill);

            foreach (var client in clients) //print
            {
                Console.WriteLine(client.Name);

                foreach (var record in client.ShopList)
                {
                    Console.WriteLine($"-- {record.Key} - {record.Value}");
                }
                Console.WriteLine($"Bill: {client.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {billTotal:f2}");
        }
    }
}