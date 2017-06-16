using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ",nums.OrderByDescending(x => x).Take(3))); 
        }
    }
}
