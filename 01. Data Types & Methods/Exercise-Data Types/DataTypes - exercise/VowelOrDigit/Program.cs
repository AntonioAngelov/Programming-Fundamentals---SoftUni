using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());
            switch (character)
            {
                case 'a':
                case 'e':
                case 'o':
                case 'i':
                case 'u':
                case 'y':
                    Console.WriteLine("vowel");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
