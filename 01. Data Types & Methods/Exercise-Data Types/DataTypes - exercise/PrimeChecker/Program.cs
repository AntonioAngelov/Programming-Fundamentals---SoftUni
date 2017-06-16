using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
