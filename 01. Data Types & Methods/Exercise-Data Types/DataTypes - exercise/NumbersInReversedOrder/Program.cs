using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(num.Reverse().ToArray());
        }
    }
}
