using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wtf = bool.Parse(Console.ReadLine());
            if (wtf)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
