using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> sqrtNums = new List<int>();
            foreach (var integer in integers)
            {
                if (Math.Sqrt(integer) == (int)Math.Sqrt(integer))
                {
                    sqrtNums.Add(integer);
                }
            }
            sqrtNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", sqrtNums));
        }
    }
}
