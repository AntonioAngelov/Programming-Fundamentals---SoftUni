﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    public class SortNumbers
    {
        public static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <=", nums));
        }
    }
}
