using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesInString
{
    class OccurrencesInString
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var w = Console.ReadLine().ToLower();
            var startPos = 0;
            var count = 0;
            while (true)
            {
                var pos = text.IndexOf(w, startPos);
                if (pos == -1)
                {
                    break;
                }
                count++;
                startPos = pos + 1;
            }
            Console.WriteLine(count);
        }
    }
}
