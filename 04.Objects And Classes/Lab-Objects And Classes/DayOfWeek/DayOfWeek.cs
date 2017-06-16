using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
