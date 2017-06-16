using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    public class ArrayModifier
    {
        public static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            while (true)
            {
                string commad = Console.ReadLine();
                if (commad == "end")
                {
                    break;
                }
                var separated = commad.Split(' ').ToArray();
                switch (separated[0])
                {
                    case "swap":
                        long buffer = 0;
                        int index1 = int.Parse(separated[1]);
                        int index2 = int.Parse(separated[2]);
                        buffer = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = buffer;
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                    case "multiply":
                        int ind1 = int.Parse(separated[1]);
                        int ind2 = int.Parse(separated[2]);
                        numbers[ind1] *= numbers[ind2];
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
