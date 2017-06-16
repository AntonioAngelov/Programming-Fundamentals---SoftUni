using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperator
{
    public class MatrixOperator
    {
        public static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            List<List<long>> array = new List<List<long>>();

            for (byte i = 0; i < rows; i++)
            {
                array.Add(Console.ReadLine().Split(' ').Select(long.Parse).ToList());
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var command = input.Split(' ').ToList();
                switch (command[0])
                {
                    case "remove":
                        array = Remove(array, command[1], command[2], int.Parse(command[3]));                       
                        break;
                    case "swap":
                        array = Swap(array, byte.Parse(command[1]), byte.Parse(command[2]));
                        break;
                    case "insert":
                        array = Insert(array, byte.Parse(command[1]), long.Parse(command[2]));                    
                        break;

                }

            }

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(string.Join(" ", array[i]));
            }
        }

        private static List<List<long>> Insert(List<List<long>> array, byte position, long element)
        {
            array[position].Insert(0, element);
            return array;
        }

        private static List<List<long>> Swap(List<List<long>> array, byte firstRow, byte secondRow)
        {
            List<long> buffer = new List<long>(array[firstRow]);
            array[firstRow] = array[secondRow];
            array[secondRow] = buffer;

            return array;

        }

        private static List<List<long>> Remove(List<List<long>> array, string type, string position, int index)
        {
            switch (type)
            {
                case "positive":
                    if (position == "row")
                    {
                        for (int i = 0; i < array[index].Count; i++)
                        {
                            if (array[index][i] > 0)
                            {
                                array[index].RemoveAt(i);
                                i -= 1;
                            }
                        }
                    }
                    else if (position == "col")
                    {
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i].Count > index)
                            {
                                if (array[i][index] > 0)
                                {
                                    array[i].RemoveAt(index);
                                }
                            }
                        }
                    }
                    break;
                case "negative":
                    if (position == "row")
                    {
                        for (int i = 0; i < array[index].Count; i++)
                        {
                            if (array[index][i] < 0)
                            {
                                array[index].RemoveAt(i);
                                i -= 1;
                            }
                        }
                    }
                    else if (position == "col")
                    {
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i].Count > index)
                            {
                                if (array[i][index] < 0)
                                {
                                    array[i].RemoveAt(index);
                                }
                            }
                        }
                    }
                    break;
                case "odd":
                    if (position == "row")
                    {
                        for (int i = 0; i < array[index].Count; i++)
                        {
                            if (array[index][i] % 2 != 0)
                            {
                                array[index].RemoveAt(i);
                                i -= 1;
                            }
                        }
                    }
                    else if (position == "col")
                    {
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i].Count > index)
                            {
                                if (array[i][index] % 2 != 0)
                                {
                                    array[i].RemoveAt(index);
                                }
                            }
                        }
                    }
                    break;
                case "even":
                    if (position == "row")
                    {
                        for (int i = 0; i < array[index].Count; i++)
                        {
                            if (array[index][i] % 2 == 0)
                            {
                                array[index].RemoveAt(i);
                                i -= 1;
                            }
                        }
                    }
                    else if (position == "col")
                    {
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i].Count > index)
                            {
                                if (array[i][index] % 2 == 0)
                                {
                                    array[i].RemoveAt(index);
                                }
                            }
                        }
                    }
                    break;
            }    
            return array;      
        }
    }
}
