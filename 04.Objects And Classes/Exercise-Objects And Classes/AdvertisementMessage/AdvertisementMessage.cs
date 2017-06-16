using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    public class AdvertisementMessage
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = new string[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = new string[] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                string currPhrase = phrases[rnd.Next(phrases.Length)];
                string currEvent = events[rnd.Next(events.Length)];
                string currAuthor = author[rnd.Next(author.Length)];
                string currCity = cities[rnd.Next(cities.Length)];

                Console.WriteLine("{0} {1} {2} - {3}", currPhrase, currEvent, currAuthor, currCity);
            }
        }
    }
}
