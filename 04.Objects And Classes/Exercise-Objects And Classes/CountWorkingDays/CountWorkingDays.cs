using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    public class CountWorkingDays
    {
        public static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(date1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(date2, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            long count = 0;
            

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1.0))
            {
                string currDay = date.DayOfWeek.ToString();
                if (currDay != "Saturday" && currDay != "Sunday" && !IsHolliday(date))
                {
                    ++count;
                }
            }
            Console.WriteLine(count);
        }
        static bool IsHolliday(DateTime date)
        {
            DateTime[] hollidays = new DateTime[]
            {
                new DateTime(1111,1,1),
                new DateTime(1111,3,3),
                new DateTime(1111,5,1),
                new DateTime(1111,5,6),
                new DateTime(1111,5,24),
                new DateTime(1111,9,6),
                new DateTime(1111,9,22),
                new DateTime(1111,11,1),
                new DateTime(1111,12,24),
                new DateTime(1111,12,25),
                new DateTime(1111,12,26)
            };

            for (int i = 0; i < 11; i++)
            {
                if (date.Day == hollidays[i].Day && date.Month == hollidays[i].Month)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
