using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                DateTime date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Book current = new Book() { title = input[0], author = input[1], publisher = input[2], releaseDate = date, ISBNnumber = input[4], price = int.Parse(input[5]) };
                library.books.Add(current);
            }
            Dictionary<string, double> pricePerAuthor = new Dictionary<string, double>();
            for (int i = 0; i < library.books.Count; i++)
            {
                if (!pricePerAuthor.ContainsKey(library.books[i].author))
                {
                    pricePerAuthor[library.books[i].author] = library.books[i].price;
                }
                else
                {
                    pricePerAuthor[library.books[i].author] += library.books[i].price;
                }
            }

            var items = from pair in pricePerAuthor
                        orderby pair.Value descending
                        select pair;

            foreach (KeyValuePair<string, double> pair in items)
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            }


        }
    }

    public class Library
    {
        public string name { get; set; }
        public List<Book> books { get; set; }
    }

    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime releaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public double price { get; set; }

    }
}
