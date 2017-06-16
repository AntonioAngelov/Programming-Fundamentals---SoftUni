using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReceipt
{
    public class PrintReceipt
    {
        public static void Main(string[] args)
        {
            List<double> prices = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double sum = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                sum += prices[i];
            }
            Console.Write('/');
            Console.Write(new string('-', 22));
            Console.WriteLine('\\');
            for (int i = 0; i < prices.Count; i++)
            {
                Console.WriteLine("| {0,20:f2} |", prices[i]);
            }
            Console.Write('|');
            Console.Write(new string('-', 22));
            Console.WriteLine('|');
            Console.WriteLine("| Total:{0,14:f2} |", sum);
            Console.Write('\\');
            Console.Write(new string('-', 22));
            Console.WriteLine('/');
        }
    }
}
