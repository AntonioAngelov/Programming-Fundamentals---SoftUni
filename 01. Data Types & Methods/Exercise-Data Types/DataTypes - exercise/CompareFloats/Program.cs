using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFloats
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            if (Math.Abs(first - second) <= eps )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
