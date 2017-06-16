using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresinMatrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            char[][] matrix = new char[dimentions[0]][];

            for (int row = 0; row < dimentions[0]; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            }
            int count = 0;
            for (int currRow = 0; currRow < dimentions[0] - 1; currRow++)
            {
                for (int currCol = 0; currCol < dimentions[1] - 1; currCol++)
                {
                    if (matrix[currRow][currCol] == matrix[currRow][currCol + 1] && matrix[currRow][currCol] == matrix[currRow + 1][currCol] && 
                        matrix[currRow][currCol] == matrix[currRow + 1][currCol + 1])
                    {
                        ++count;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
