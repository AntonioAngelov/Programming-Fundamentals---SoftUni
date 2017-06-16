using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr1 = arr.Take(arr.Length / 4).ToArray();
            Array.Reverse(arr1);
            Array.Reverse(arr);
            int[] arr2 = arr.Take(arr.Length / 4).ToArray();
            arr1 = arr1.Concat(arr2).ToArray();
            int[] arr3 = arr.Skip(arr.Length / 4).Take(arr.Length / 2).ToArray();
            Array.Reverse(arr3);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + arr3[i] + " ");
            }
            
        }
    }
}
