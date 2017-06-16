using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trifon_sQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            long health = long.Parse(Console.ReadLine());
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[][] map = GetMap(rows, cols);
            uint turns = 0;
            bool alive = true;
            for (int currCol = 0; currCol < cols; currCol++)
            {
                if (currCol % 2 == 0)
                {
                    for (int currRow = 0; currRow < rows; currRow++)
                    {                      
                        switch (map[currRow][currCol])
                        {
                            case 'F':                             
                                health = health - turns/2;
                                if (health <= 0)
                                {
                                    alive = false;
                                }
                                turns = turns + 1;
                                break;
                            case 'H':
                                health = health + turns/3;
                                turns = turns + 1;
                                break;
                            case 'T':
                                turns = turns + 3;                             
                                break;
                            case 'E':
                                turns = turns + 1;
                                break;
                        }

                        if (!alive)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", currRow, currCol);
                            break;
                        }
                    }

                }
                else 
                {
                    for (int currRow = rows - 1; currRow >= 0; currRow--)
                    {
                        switch (map[currRow][currCol])
                        {
                            case 'F':
                                health = health - turns/2;
                                if (health <= 0)
                                {
                                    alive = false;
                                }
                                turns = turns + 1;
                                break;
                            case 'H':
                                health = health + turns/3;
                                turns = turns + 1;
                                break;
                            case 'T':
                                turns = turns + 3;
                                break;
                            case 'E':
                                turns = turns + 1;
                                break;
                        }
                        if (!alive)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", currRow, currCol);
                            break;
                        }

                    }
                }

                if (!alive) break;
            }

            if (alive)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: {0}", health);
                Console.WriteLine("Turns: {0}", turns);
            }
        }

        private static char[][] GetMap(int rows, int cols)
        {
            char[][] map = new char[rows][];
            for (int i = 0; i < rows; i++)
            {               
                    map[i] = Console.ReadLine().ToCharArray();            
            }
            return map;
        }
    }
}
