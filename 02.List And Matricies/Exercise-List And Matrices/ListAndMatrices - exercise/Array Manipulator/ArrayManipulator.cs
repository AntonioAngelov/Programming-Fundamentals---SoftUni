using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(command[1]), long.Parse(command[2]));
                        break;
                    case "addMany":
                        List<long> toAdd = new List<long>();
                        for (int i = 2; i < command.Count; i++)
                        {
                            toAdd.Add(long.Parse(command[i]));
                        }
                        numbers.InsertRange(int.Parse(command[1]), toAdd);
                        break;
                    case "contains":
                        Console.WriteLine(numbers.IndexOf(int.Parse(command[1])));
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "shift":
                        long[] shifted = new long[numbers.Count];
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (i - int.Parse(command[1]) + numbers.Count < 0)
                            {
                                int pos = (i - int.Parse(command[1]) + numbers.Count) * -1;
                                shifted[pos % numbers.Count] = numbers[i];
                            }
                            else
                            {
                                int pos = (i - int.Parse(command[1]) + numbers.Count);
                                shifted[pos % numbers.Count] = numbers[i];
                            }
                            
                        }
                        numbers = shifted.ToList();
                        break;
                    case "sumPairs":
                        List<long> SumNums = new List<long>();
                        for (int i = 0; i < numbers.Count - 1; i+=2)
                        {
                            SumNums.Add(numbers[i] + numbers[i + 1]);
                        }
                        if (numbers.Count % 2 != 0)
                        {
                            SumNums.Add(numbers[numbers.Count - 1]);
                        }
                        numbers = SumNums;
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
           
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
