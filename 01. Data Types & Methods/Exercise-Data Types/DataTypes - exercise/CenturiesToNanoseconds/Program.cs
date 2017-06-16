using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = (long)(years * 365.2425);
            decimal hours = days * 24;
            decimal mins = hours * 60;
            decimal seconds = mins * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, mins, seconds, milliseconds, microseconds, nanoseconds);
            
        }
    }
}
