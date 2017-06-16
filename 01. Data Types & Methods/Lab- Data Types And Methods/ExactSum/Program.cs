using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal[] arr = new decimal[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = decimal.Parse(Console.ReadLine());
            }
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
