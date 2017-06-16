using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char i = 'a';  i < 'a' + n; i++)
            {
                for (char k = 'a'; k < 'a' + n; k++)
                {
                    for (char m = 'a'; m < 'a' + n; m++)
                    {
                        Console.WriteLine("{0}{1}{2}",i , k, m);
                    }
                }
            }
        }
    }
}
