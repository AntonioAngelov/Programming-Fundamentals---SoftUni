using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main(string[] args)
        {
            List<double> realNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            bool hasEquals = true;
            while (hasEquals)
            {
                hasEquals = false;

                for (int i = 0; i < realNumbers.Count - 1; i++)
                {
                    if (realNumbers[i] == realNumbers[i + 1])
                    {
                        realNumbers[i] *= 2;
                        realNumbers.RemoveAt(i + 1);
                        hasEquals = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", realNumbers));
        }
    }
}
