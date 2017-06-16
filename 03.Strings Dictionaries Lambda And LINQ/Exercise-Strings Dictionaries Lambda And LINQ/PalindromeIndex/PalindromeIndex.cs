using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class PalindromeIndex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (isPalindrome(input))
            {
                Console.WriteLine(-1);
            }

            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    List<char> list = input.ToArray().ToList();
                    list.RemoveAt(i);
                    string current = string.Join("", list);
                    if (isPalindrome(current))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }

        static bool isPalindrome(string s)
        {
            string reversed = string.Join("", s.ToArray().Reverse());
            if (s == reversed)
            {
                return true;
            }
            return false;
        }
    }
}
