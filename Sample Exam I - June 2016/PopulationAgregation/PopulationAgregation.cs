using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationAgregation
{
    public class PopulationAgregation
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, int> townsByCountry = new SortedDictionary<string, int>();
            Dictionary<string, ulong> populationByTown = new Dictionary<string, ulong>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                List<string> list = input.Split('\\').ToList();
                var country = RemoveSymbols(list[0]);
                var town = RemoveSymbols(list[1]);

                if (char.IsUpper(town[0]))
                {
                    var current = town;
                    town = country;
                    country = current;
                }

                if (townsByCountry.ContainsKey(country))
                {
                    townsByCountry[country] += 1;
                }
                else
                {
                    townsByCountry[country] = 0;
                    townsByCountry[country] += 1;
                }

                populationByTown[town] = ulong.Parse(list[2]);
            }

            foreach (var coutry in townsByCountry)
            {
                Console.WriteLine("{0} -> {1}", coutry.Key, coutry.Value);
            }

            var mostPopulatedTowns = populationByTown.OrderByDescending(x => x.Value).Take(3);
            foreach (var town in mostPopulatedTowns)
            {
                Console.WriteLine("{0} -> {1}", town.Key, town.Value);
            }
        }

        private static string RemoveSymbols(string str)
        {
            var cleared = str.Split("@#$&0123456789".ToCharArray());
            var final = string.Join("", cleared);
            return final;
        }    
    }
}
