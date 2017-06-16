using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hi = "Hello";
            string world = "World";
            world = " " + world;
            object hiWorld = string.Concat(hi, world);
            Console.WriteLine(hiWorld);
        }
    }
}
