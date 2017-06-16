using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOfASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            for (char i = (char)start; i <= (char)finish; i++)
            {
                Console.Write(i);
                if (i != finish)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
