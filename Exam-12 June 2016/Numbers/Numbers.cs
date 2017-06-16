using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Numbers
    {
        public static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double average = numbers.Average();        
            var top5 = numbers.Where(number => number > average).OrderByDescending(x => x).Take(5).ToArray();
            for (int i = 0; i < top5.Length; i++)
            {
                Console.Write(top5[i] + " ");
            }

            if (top5.Length == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
