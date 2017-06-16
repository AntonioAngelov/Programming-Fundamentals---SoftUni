using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n ; i++)
            {
                if (Palindrome(i) && DivBy7(i) && EvenInside(i))
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        static bool Palindrome(int num)
        {
            int reverse = 0;
            int buffer = num;
            while (buffer > 0)
            {
                int lastDig = buffer % 10;
                reverse = reverse * 10 + lastDig;
                buffer /= 10;
            }
            if (num == reverse)
            {
                return true;
            }
            return false;
        }

        static bool DivBy7(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }
        
        static bool EvenInside(int num)
        {
            while (num > 0)
            {
                int current = num % 10;
                if (current % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        
    }
}
