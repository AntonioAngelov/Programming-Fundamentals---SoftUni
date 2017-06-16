using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine(centuries);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}
