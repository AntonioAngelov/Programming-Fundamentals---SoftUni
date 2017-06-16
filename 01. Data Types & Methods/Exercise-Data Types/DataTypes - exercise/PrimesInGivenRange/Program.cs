using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(FindPrimesInRange(start, end));
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i != list.Count - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }
            List<int> list1 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (IsPrime(list[i]))
                {
                    list1.Add(list[i]);
                }
            }
            return list1;
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
