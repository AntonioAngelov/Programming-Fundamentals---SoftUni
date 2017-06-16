using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                char[] current = numbers[i].ToArray();
                Array.Reverse(current);
                string final = new string(current);
                sum += int.Parse(final);
            }
            Console.WriteLine(sum);
        }
    }
}
