using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    public class SalesReport
    {
        public static void Main(string[] args)
        {
            Sale[] sales = ReadSales();
            SortedDictionary<string, decimal> salesPerTown = new SortedDictionary<string, decimal>();
            foreach (var sale in sales)
            {
                if (!salesPerTown.ContainsKey(sale.Town))
                {
                    salesPerTown[sale.Town] = 0;
                    salesPerTown[sale.Town] += (decimal)sale.Price * sale.Quantity;
                }
                else
                {
                    salesPerTown[sale.Town] += (decimal)sale.Price * sale.Quantity;
                }
            }

            foreach (var town in salesPerTown)
            {
                Console.WriteLine("{0} -> {1:f2}", town.Key, town.Value );
            }
        }

        static Sale ReadSale()
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = double.Parse(items[2]),
                Quantity = decimal.Parse(items[3])
            };
        }

        static Sale[] ReadSales()
        {
            var n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public decimal Quantity { get; set; }
    }
}