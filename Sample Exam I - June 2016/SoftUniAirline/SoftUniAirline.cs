using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniAirline
{
    public class SoftUniAirline
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal income = 0;
            for (int i = 0; i < n; i++)
            {
                decimal adultPassengersCount = decimal.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                decimal youthPassengersCount = decimal.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal	fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal	fuelconsumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal	flightDuration = decimal.Parse(Console.ReadLine());

                decimal incomeByTickets = adultPassengersCount*adultTicketPrice + youthPassengersCount*youthTicketPrice;
                decimal expences = fuelPricePerHour*fuelconsumptionPerHour*flightDuration;
                decimal total = incomeByTickets - expences;
                if (total >= 0)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", total);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", total);
                }

                income += total;
            }

            Console.WriteLine("Overall profit -> {0:f3}$.", income);
            Console.WriteLine("Average profit -> {0:f3}$.", income / n);

        }
    }
}
