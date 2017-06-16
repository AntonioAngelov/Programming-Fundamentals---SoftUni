using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUppercase
{
    public class ToUppercase
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string modified = string.Empty;
            string start = "<upcase>";
            string end = "</upcase>";
            for (int i = 0; i < text.Length; i++)
            {
                int indexStart = text.IndexOf(start, i);
                int indexEnd = text.IndexOf(end, i);

                if (i == indexStart)
                {
                    for (int k = indexStart + start.Length; k < indexEnd; k++)
                    {
                        modified += text[k].ToString().ToUpper();
                    }
                    i += indexEnd - indexStart + end.Length;
                }

                if (i < text.Length)
                {
                    modified += text[i];
                }
            }

            Console.WriteLine(modified);

        }
    }
}
