using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    public class RotateMatrix
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[][] matrix = new string[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').ToArray();
            }
            for (int i = 0; i < cols; i++)
            {
                for (int j = rows -1 ; j >= 0; j--)
                {
                    Console.Write(matrix[j][i] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
