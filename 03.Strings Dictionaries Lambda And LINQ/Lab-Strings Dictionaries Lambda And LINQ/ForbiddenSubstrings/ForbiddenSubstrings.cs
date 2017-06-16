using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenSubstrings
{
    class ForbiddenSubstrings
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var words = Console.ReadLine().Split(' ');

            foreach (var w in words)
            {
                var stars = new string('*', w.Length);
                text = text.Replace(w, stars);
            }
            Console.WriteLine(text);
        }
    }
}
