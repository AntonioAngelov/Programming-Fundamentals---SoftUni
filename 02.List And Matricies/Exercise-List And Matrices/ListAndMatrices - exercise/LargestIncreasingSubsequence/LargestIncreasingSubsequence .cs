using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestIncreasingSubsequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] length = new int[numbers.Count];
            int[] previous = new int[numbers.Count];
            int maxLength = 0;
            int lastIndex = -1;
            for (int x = 0; x < numbers.Count; x++)
            {
                length[x] = 1;
                previous[x] = -1;
                for (int i = 0; i < x; i++)
                {
                    if (numbers[i] < numbers[x] && length[i] + 1 > length[x])
                    {
                        length[x] = length[i] + 1;
                        previous[x] = i;
                    }

                    if (length[x] > maxLength)
                    {
                        maxLength = length[x];
                        lastIndex = x;
                    }
                }
            }

            var longest = new List<int>();

            while (lastIndex != -1)
            {
                longest.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longest.Reverse();
            foreach (var number in longest)
            {
                Console.Write(number + " ");
            }

            if (numbers.Count == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            
        }
    }
}
