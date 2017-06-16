using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    public class Tour
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] distance = new long[n][];
            for (int i = 0; i < n; i++)
            {
                distance[i] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            }

            List<long> rout = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long start = 0;
            long distanceSum = 0;
            for (int end = 0; end < rout.Count; end++)
            {
                distanceSum += distance[start][rout[end]];
                start = rout[end];
            }

            Console.WriteLine(distanceSum);
        }
    }
}
