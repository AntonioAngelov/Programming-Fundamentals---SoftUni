using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> palidromes = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                string reversed = string.Join("",words[i].ToArray().Reverse());
                if (words[i] == reversed)
                {
                    palidromes.Add(words[i]);
                }
            }
            palidromes.Sort();
            Console.WriteLine(string.Join(", ", palidromes.Distinct()));
        }
    }
}
