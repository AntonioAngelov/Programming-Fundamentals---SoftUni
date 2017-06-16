using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] arr = s.ToArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join("", arr));
        }
    }
}
