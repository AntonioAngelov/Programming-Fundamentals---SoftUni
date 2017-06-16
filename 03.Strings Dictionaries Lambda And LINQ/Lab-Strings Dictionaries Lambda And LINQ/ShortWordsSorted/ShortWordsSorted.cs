using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split(new char[] { '.', ' ', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).ToList();
            words.Sort();
            Console.WriteLine(string.Join(", ",words.Distinct()));

        }
           
    }
}
