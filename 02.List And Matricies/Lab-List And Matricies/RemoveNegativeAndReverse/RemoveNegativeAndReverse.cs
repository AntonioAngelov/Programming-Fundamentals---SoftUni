using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        public static void Main(string[] args)
        {
            //List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).Where(num => num > 0).ToList();
            list.RemoveAll(num => num < 0);
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
