using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                ulong capsuleCount = ulong.Parse(Console.ReadLine());

                decimal currentPrice = 0;
                int daysInCurrentMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                currentPrice = capsuleCount*pricePerCapsule*daysInCurrentMonth;
                total += currentPrice;
                Console.WriteLine("The price for the coffee is: ${0:f2}", currentPrice);
            }

            Console.WriteLine("Total: ${0:f2}", total);

        }
    }
}
