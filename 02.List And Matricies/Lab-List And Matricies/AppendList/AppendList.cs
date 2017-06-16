using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    public class AppendList
    {
        public static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            lists.Reverse();
            List<int> result = new List<int>();
            foreach (string list in lists)
            {
                result.AddRange(list.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
