using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourglassSum
{
    public class HourglassSum
    {
        public static void Main(string[] args)
        {
            long[][] matrix = new long[6][];

            for (int row = 0; row < 6; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            }

            long maxSum = long.MinValue;

            for (int currRow = 0; currRow < 4; currRow++)
            {
                for (int currCol = 0; currCol < 4; currCol++)
                {
                    long currSum = matrix[currRow][currCol] + matrix[currRow + 2][currCol] +
                        matrix[currRow][currCol + 1] + matrix[currRow][currCol + 2] + matrix[currRow + 1][currCol + 1] +
                        matrix[currRow + 2][currCol + 1] + matrix[currRow + 2][currCol + 2];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;                     
                    }
                }

            }

            Console.WriteLine(maxSum);

        }
    }
}
