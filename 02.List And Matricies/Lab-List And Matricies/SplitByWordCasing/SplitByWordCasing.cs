using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
   public class SplitByWordCasing
    {
        public static void Main(string[] args)
        {
            char[] delimeters = new char[] { ',', ';', ':', '.', '!', '(', ')', '\"','\'', '\\', '/', '[', ']', ' ' };
            string[] words = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var word in words)
            {
                bool containsUpper = false;
                bool containsLower = false;
                bool containsSymbol = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] >=65 && word[i] <= 90)
                    {
                        containsUpper = true;
                    }

                    else if (word[i] >= 97 && word[i] <= 122)
                    {
                        containsLower = true;
                    }

                    else
                    {
                        containsSymbol = true;
                    }
                }
                  if (containsUpper && containsLower || containsSymbol)
                {
                    mixedCase.Add(word);
                }
               

                else if (containsLower)
                {
                    lowerCase.Add(word);
                }

                else if (containsUpper)
                {
                    upperCase.Add(word);
                }


            }

            Console.WriteLine("Lower-case: " + string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
