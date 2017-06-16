using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInSentence
{
    public class ReverseWordsInSentence
    {
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            words.Reverse();
            List<string> tempWords = new List<string>(words);
            tempWords.Sort((e1, e2) => e2.Length.CompareTo(e1.Length));
            List<string> symbols = sentence.Split(tempWords.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                Console.Write(words[i] + symbols[i]);
            }


        }
    }
}
