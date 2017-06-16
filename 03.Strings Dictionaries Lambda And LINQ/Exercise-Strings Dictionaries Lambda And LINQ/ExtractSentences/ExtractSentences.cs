using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string toFind = Console.ReadLine();
            string toFind2 = toFind.ToLower();
            string[] sentences = Console.ReadLine().Split(new char[] { '.', '!', '?' } , StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] current = sentences[i].Split(new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (current.Contains(toFind) || current.Contains(toFind2))
                {
                    Console.WriteLine(sentences[i]);
                }


            }
      
          
        }

       
    }
}
