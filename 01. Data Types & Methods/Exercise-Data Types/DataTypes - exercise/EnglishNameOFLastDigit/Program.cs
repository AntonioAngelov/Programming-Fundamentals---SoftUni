using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOFLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            int last = Convert.ToInt32(number.ToString().AsEnumerable().Last().ToString());
            Console.WriteLine(GetName(last)); 
        }

        private static string GetName(int v)
        {
            switch (v)
            {
                case 0:
                   return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                   return "three";
                case 4:
                    return "four";
                case 5:
                   return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                   return "eight";
                case 9:
                   return "nine";
                default:
                    return "\0";
            }
        }
    }
}
