using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStringIn20Chars
{
    public class FitStringIn20Chars
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Length > 20)
            {
                var result = s.Substring(0, 20);
                Console.WriteLine(result);
            }
            else
            {
                var result2 = s.PadRight(20, '*');
                Console.WriteLine(result2);
            }
        }
    }
}
