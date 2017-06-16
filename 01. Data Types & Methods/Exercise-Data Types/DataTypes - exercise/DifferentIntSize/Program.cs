using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            bool flag = true;
            checked
            {
                try
                {
                    long myInt = long.Parse(n);

                }
                catch (OverflowException)
                {
                    Console.WriteLine(n + " can't fit in any type");
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine(n + " can fit in:");
            }
            
            checked
            {
                try
                {
                    sbyte m = sbyte.Parse(n);
                    Console.WriteLine("* sbyte");
                }
                catch (OverflowException)
                {
                }
            }

            checked
            {
                try
                {
                    byte m = byte.Parse(n);
                    Console.WriteLine("* byte");
                }
                catch (OverflowException)
                {                
                }
            }

            checked
            {
                try
                {
                    short m = short.Parse(n);
                    Console.WriteLine("* short");
                }
                catch (OverflowException)
                {
                }
            }

            checked
            {
                try
                {
                    ushort m = ushort.Parse(n);
                    Console.WriteLine("* ushort");
                }
                catch (OverflowException)
                {
                }
            }

            checked
            {
                try
                {
                    int m = int.Parse(n);
                    Console.WriteLine("* int");
                }
                catch (OverflowException)
                {
                }
            }

            checked
            {
                try
                {
                    uint m = uint.Parse(n);
                    Console.WriteLine("* uint");
                }
                catch (OverflowException)
                {
                }
            }

            checked
            {
                try
                {
                    long m = long.Parse(n);
                    Console.WriteLine("* long");
                }
                catch (OverflowException)
                {
                }
            }

        }
    }
}
