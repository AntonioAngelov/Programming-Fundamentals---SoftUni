using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDesert
{
    public class SweetDesert
    {
        public static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            ulong numberOfGuests = ulong.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            decimal numberOfDeserts = numberOfGuests/ 6;
            if (numberOfGuests%6 != 0)
            {
                numberOfDeserts += 1;
            }

            decimal bananasNeeded = 2 *numberOfDeserts;
            decimal eggsNeeded = 4*numberOfDeserts;
            decimal berriesNeeded = (decimal) (0.2 *(double) numberOfDeserts);

            decimal totalMoneyNeeded = bananasNeeded*priceOfBananas + eggsNeeded*priceOfEggs + berriesNeeded*priceOfBerries;

            if (totalMoneyNeeded <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalMoneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", totalMoneyNeeded - cash);                  
            }

        }
    }
}
