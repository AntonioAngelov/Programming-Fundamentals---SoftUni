using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonStrings
{
    class CommonStrings
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            if (A.Length > B.Length)
            {
                string C = A;
                A = B;
                B = C;
            }

            bool found = false;
            for (int i = 0; i < A.Length; i++)
            {
                for (int k = 1; k <= A.Length - i; k++)
                {
                    string curent = A.Substring(i, k);
                    if (B.Contains(curent))
                    {
                        Console.WriteLine("yes");
                        found = true;
                        break;
                    }                  
                }

                if (found)
                {
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
