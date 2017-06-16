using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    public class CountNumbers
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;
            int previous = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (previous == numbers[i])
                {
                    count++;               
                }
                else
                {
                    Console.WriteLine(previous + " -> " + count);
                    previous = numbers[i];
                    count = 1;
                    
                }
            }
            Console.WriteLine(previous + " -> " + count);
        }
    }
}
