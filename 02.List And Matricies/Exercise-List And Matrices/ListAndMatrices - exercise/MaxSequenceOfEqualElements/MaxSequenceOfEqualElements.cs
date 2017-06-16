using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            int max = numbers.First();
            int maxCount = 1;
            int current = numbers.First();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (current == numbers[i])
                {
                    ++count;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        max = current;
                    }
                }
                else
                {
                    current = numbers[i];
                    count = 1;
                }
                
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(max + " ");
            }

        }
    }
}
