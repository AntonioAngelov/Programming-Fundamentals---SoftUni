using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var words = text.Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            List<string> final = new List<string>();
            foreach (var item in counts.Keys)
            {
                if (counts[item] % 2 != 0)
                {
                    final.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", final));
        }
    }
}
