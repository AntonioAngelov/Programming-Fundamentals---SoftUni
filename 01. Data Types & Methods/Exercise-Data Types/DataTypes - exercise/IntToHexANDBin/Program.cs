using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToHexANDBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16).ToUpper();
            string bin = Convert.ToString(n, 2);
            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
