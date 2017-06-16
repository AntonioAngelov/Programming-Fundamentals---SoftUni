using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                List<string> list = input.Split(' ').ToList();
                switch (list[0])
                {
                    case "A":
                        if (list.Count > 2)
                        {
                            phonebook[list[1]] = list[2];
                        }
                        else if (!phonebook.ContainsKey(list[1]))
                        {
                            phonebook[list[1]] = "";
                        }
                        break;
                    case "S":
                        if (!phonebook.ContainsKey(list[1]))
                        {
                            Console.WriteLine("Contact {0} does not exist.", list[1]);
                        }
                        else
                        {
                            Console.WriteLine("{0} -> {1}", list[1], phonebook[list[1]]);
                        }
                        break;
                    case "ListAll":
                        foreach (var key in phonebook.Keys)
                        {
                            Console.WriteLine("{0} -> {1}", key, phonebook[key]);
                        }
                        break;
                }
            }

        }
    }
}
