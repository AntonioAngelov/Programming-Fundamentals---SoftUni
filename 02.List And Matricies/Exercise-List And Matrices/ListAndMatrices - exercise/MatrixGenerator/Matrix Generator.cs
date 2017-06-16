using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> parameters = Console.ReadLine().Split(' ').ToList();
            int[,] result = new int[int.Parse(parameters[1]), int.Parse(parameters[2])];
            switch (parameters[0])
            {
                case "A":
                   result =  getTypeA(int.Parse(parameters[1]), int.Parse(parameters[2]));
                    break;
                case "B":
                   result = getTypeB(int.Parse(parameters[1]), int.Parse(parameters[2]));
                    break;
                case "C":
                    result = getTypeC(int.Parse(parameters[1]), int.Parse(parameters[2]));
                    break;
                case "D":
                    result = getTypeD(int.Parse(parameters[1]), int.Parse(parameters[2]));
                    break;
            }

            for (int i = 0; i < int.Parse(parameters[1]); i++)
            {
                for (int k = 0; k < int.Parse(parameters[2]); k++)
                {
                    Console.Write(result[i, k] + " ");
                }
                Console.WriteLine();
            }

        }

        private static int[,] getTypeD(int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            string directions = "down";
            int current = 1;
            int currentRow = -1;
            int currentCol = 0;
            while (contains(result , rows, cols))
            {
                if (directions == "down" && currentRow + 1 < rows)
                {
                    ++currentRow;
                    result[currentRow, currentCol] = current;
                    if (currentRow == rows - 1 || result[currentRow + 1, currentCol] != 0)
                    {
                        directions = "right";
                    }
                    ++current;
                }

               else if (directions == "right" && currentCol + 1 < cols)
                {
                    ++currentCol;
                    result[currentRow, currentCol] = current++;
                    if (currentCol == cols - 1 || result[currentRow, currentCol + 1] != 0)
                    {
                        directions = "up";
                    }
                }

               else if (directions == "up" && currentRow - 1 >= 0)
                {
                    --currentRow;
                    result[currentRow, currentCol] = current++;
                    if (currentRow == 0 || result[currentRow - 1, currentCol] != 0)
                    {
                        directions = "left";
                    }
                }

                else if (directions == "left" && result[currentRow, currentCol - 1] == 0)
                {
                    --currentCol;
                    result[currentRow, currentCol] = current++;
                    if (result[currentRow, currentCol - 1] != 0)
                    {
                        directions = "down";
                    }
                }
            }
            return result;
        }

        private static int[,] getTypeC(int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            int current = 1;
            for (int startRow = rows - 1; startRow >= 0; startRow--)
            {
                int currentRow = startRow;
                int currentCol = 0;
                while (currentRow < rows )
                {
                    result[currentRow, currentCol] = current;
                    ++currentRow;
                    ++currentCol;
                    ++current;
                }
            }

            for (int startCol = 1; startCol < cols; startCol++)
            {
                int currentCol = startCol;
                int currentRow = 0;
                while (currentCol < cols)
                {
                    result[currentRow, currentCol] = current;
                    ++currentCol;
                    ++currentRow;
                    ++current;
                }
            }
            return result;
        }

        private static int[,] getTypeB(int rows, int cols)
        {
            int[,] result = new int[rows, cols];

            int direction = 1;
            int current = 1;
            for (int currCol = 0; currCol < cols; currCol++)
            {
                if (direction > 0)
                {
                    for (int currRow = 0; currRow < rows; currRow++)
                    {
                        result[currRow, currCol] = current;
                        ++current;
                    }
                }
                else
                {
                    for (int currRow = rows -1 ; currRow >= 0; currRow--)
                    {
                        result[currRow, currCol] = current;
                        ++current;
                    }
                }
                direction *= -1;
            }
            
            return result;
        }

        private static int[,] getTypeA(int rows, int cols)
        {
            int[,] result = new int[rows, cols];          
            int current = 1;
            for (int i = 0; i < cols; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    result[k, i] = current;
                    ++current;
                }
            }
            return result;
        }

        private static bool contains(int[,] arr, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (arr[i, k] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
