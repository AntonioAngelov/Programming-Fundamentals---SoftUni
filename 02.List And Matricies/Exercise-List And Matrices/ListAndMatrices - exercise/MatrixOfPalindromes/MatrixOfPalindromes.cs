using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main(string[] args)
        {
            List<int> rolCol = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int currRow = 97; currRow < 97 + rolCol[0]; currRow++)
            {
                for (int currCol = currRow; currCol < currRow + rolCol[1]; currCol++)
                {
                    Console.Write("{0}{1}{2} ", (char)currRow, (char)currCol, (char)currRow);
                }
                Console.WriteLine();
            }
        }
    }
}
