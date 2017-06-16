using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalization
{
    class Capitalization
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string current = string.Empty;
                for (int k = 0; k < input[i].Length; k++)
                {
                    if (k == 0)
                    {
                        current += input[i][0].ToString().ToUpper();
                    }
                    else
                    {
                        current += input[i][k];
                    }
                }
                result.Add(current);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
