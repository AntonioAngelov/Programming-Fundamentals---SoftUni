using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                var pos2 = rnd.Next(words.Length);
                var buffer = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = buffer;             
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
