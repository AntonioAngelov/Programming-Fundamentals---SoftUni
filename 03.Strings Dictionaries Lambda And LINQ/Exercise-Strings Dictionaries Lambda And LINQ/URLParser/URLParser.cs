using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParser
{
    public class URLParser
    {
        public static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (parts.Length == 1)
            {
                Console.WriteLine("[protocol] = \"\"");
                Console.WriteLine("[server] = \"{0}\"", parts[0]);
                Console.WriteLine("[resource] = \"\"");
            }
            else if (parts.Length == 2)
            {
                Console.WriteLine("[protocol] = \"{0}\"", parts[0]);
                Console.WriteLine("[server] = \"{0}\"", parts[1]);
                Console.WriteLine("[resource] = \"\"");
            }     
            else
            {
                string[] smth = new string[parts.Length - 2];

                for (int i = 2; i < parts.Length; i++)
                {
                    smth[i - 2] = parts[i];
                }
                Console.WriteLine("[protocol] = \"{0}\"", parts[0]);
                Console.WriteLine("[server] = \"{0}\"", parts[1]);
                Console.WriteLine("[resource] = \"{0}\"", string.Join("/", smth));
            }

        }
    }
}
