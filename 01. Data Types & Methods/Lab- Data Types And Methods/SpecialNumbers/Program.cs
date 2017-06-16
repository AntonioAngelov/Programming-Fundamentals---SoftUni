using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum;
            int buffer;
            for (int i = 1; i <= n; i++)
            {
               buffer = i;
                sum = 0;
                do
                {
                    sum += buffer % 10;
                    buffer /= 10;
                } while (buffer != 0);

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
