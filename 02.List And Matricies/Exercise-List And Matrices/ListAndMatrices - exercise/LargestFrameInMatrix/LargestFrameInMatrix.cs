using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestFrameInMatrix
{
    public class LargestFrameInMatrix
    {
        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            List<int> framesRows = new List<int>();
            List<int> framesCols = new List<int>();
            for (int startRow = 0; startRow < rows; startRow++)
            {
                for (int startCol = 0; startCol < cols; startCol++)
                {
                    for (int endRow = rows - 1; endRow >= startRow; endRow--)
                    {
                        for (int endCol = cols - 1; endCol >= startCol; endCol--)
                        {
                            if (isFrame(matrix, startRow, startCol, endRow, endCol))
                            {
                                framesRows.Add(endRow - startRow + 1);
                                framesCols.Add(endCol - startCol + 1);
                            }
                        }
                    }
                }
            }
            List<string> frames = findFrames(framesRows, framesCols);
            frames.Sort();
            Console.WriteLine(string.Join(", ", frames));

        }

        private static List<string> findFrames(List<int> framesRows, List<int> framesCols)
        {
            List<string> frames = new List<string>();
            int max = 0;
            for (int i = 0; i < framesCols.Count; i++)
            {
                if (framesCols[i] * framesRows[i] > max)
                {
                    max = framesCols[i] * framesRows[i];
                }
            }

            for (int i = 0; i < framesCols.Count; i++)
            {
                if (framesCols[i] * framesRows[i] == max)
                {
                    frames.Add(framesRows[i] + "x" + framesCols[i]);
                }
            }
            return frames;
        }

        static bool isFrame(int[][] matrix, int startRow,int startCol, int endRow, int endCol)
        {
            int currentCell = matrix[startRow][startCol];
            for (int col = startCol; col <= endCol; col++)
            {
                if (matrix[startRow][col] != currentCell || matrix[endRow][col] != currentCell)
                {
                    return false;
                }
            }

            for (int row = startRow; row <= endRow; row++)
            {
                if (matrix[row][startCol] !=currentCell || matrix[row][endCol] != currentCell)
                {
                    return false;
                }
            }
            return true;
        }
       
    }
}
