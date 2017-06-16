using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", three, two, one);
        }
    }
}
