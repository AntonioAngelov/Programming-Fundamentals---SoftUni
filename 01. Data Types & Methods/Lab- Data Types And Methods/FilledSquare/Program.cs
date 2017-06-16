using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 2 * n));
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("-");
                for (int k = 0; k < n - 1; k++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
