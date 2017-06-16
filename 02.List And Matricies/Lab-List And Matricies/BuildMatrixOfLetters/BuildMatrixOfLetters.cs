using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildMatrixOfLetters
{
    public class BuildMatrixOfLetters
    {
        public static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            char[][] matrix = new char[row][];

            for (int currRow = 0; currRow < row; currRow++)
            {
                matrix[currRow] = new char[col];
            }

            char filler = 'A';

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                {
                    matrix[currRow][currCol] = filler;
                    filler++;
                }
            }

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                {
                    Console.Write(matrix[currRow][currCol] + " " );
                }
                Console.WriteLine();
            }
        }
    }
}
