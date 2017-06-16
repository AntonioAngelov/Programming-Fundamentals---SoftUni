using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlatform3_x_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            long[][] matrix = new long[dimentions[0]][];

            for (int row = 0; row < dimentions[0]; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            }

            long maxSum = long.MinValue;
            long startRow = 0;
            long startCol = 0;

            for (int currRow = 0; currRow < dimentions[0] - 2; currRow++)
            {
                for (int currCol = 0; currCol < dimentions[1] - 2; currCol++)
                {
                    long currSum = matrix[currRow][currCol] + matrix[currRow + 1][currCol] + matrix[currRow + 2][currCol] + 
                        matrix[currRow][currCol + 1] + matrix[currRow][currCol + 2] + matrix[currRow + 1][currCol + 1] + 
                        matrix[currRow + 1][currCol + 2] + matrix[currRow + 2][currCol + 1] + matrix[currRow + 2][currCol + 2];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        startRow = currRow;
                        startCol = currCol;
                    }
                }
               
            }
            Console.WriteLine(maxSum);
            for (long i = startRow; i < startRow + 3; i++)
            {
                for (long k = startCol; k < startCol + 3; k++)
                {
                    Console.Write(matrix[i][k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
