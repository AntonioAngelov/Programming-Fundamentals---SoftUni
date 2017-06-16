using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();        
            }
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i][i];
            }

            for (int i = 0; i < n; i++)
            {
                Array.Reverse(matrix[i]);
            }

            for (int i = 0; i < n; i++)
            {
                sum2 += matrix[i][i];
            }

            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
