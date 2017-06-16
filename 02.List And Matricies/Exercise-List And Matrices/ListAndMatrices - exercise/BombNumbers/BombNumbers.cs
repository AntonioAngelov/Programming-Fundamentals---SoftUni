using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<int> detonate = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int currentIndex = 0;
            while (currentIndex < numbers.Count)
            {
                if (numbers[currentIndex] == detonate[0])
                {
                    if (currentIndex - detonate[1] <= 0 && currentIndex + detonate[1] < numbers.Count)
                    {
                        numbers.RemoveRange(0, currentIndex + 1 + detonate[1]);
                    }
                    else if (currentIndex - detonate[1] >= 0 && currentIndex + detonate[1] >= numbers.Count)
                    {
                        numbers.RemoveRange(currentIndex - detonate[1], detonate[1] + 1 + numbers.Count - (currentIndex + 1));
                    }
                    else if (currentIndex - detonate[1] <= 0 && currentIndex + detonate[1] >= numbers.Count)
                    {
                        numbers.RemoveRange(0, numbers.Count);
                    }
                    else if (currentIndex - detonate[1] >= 0 && currentIndex + detonate[1] < numbers.Count) 
                    {
                        numbers.RemoveRange(currentIndex - detonate[1], 2 * detonate[1] + 1);
                    }
                }

                else
                {
                    ++currentIndex;
                }
            }
            long sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
