using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Books = new List<Book>();
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i<num; i++)
                library.Books.Add(Book.Read(Console.ReadLine()));
            /*Dictionary<string, double> query = library.Books.GroupBy(x => x.author).Select(x => new { x.Key, Value = x.Sum(y => y.price) }).OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            foreach (var author in query)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }*/
            DateTime after = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            Dictionary<string, DateTime>qeury = library.Books.Select(x => new { x.title, x.releaseDate }).Where(x => x.releaseDate.CompareTo(after) > 0).OrderBy(x => x.releaseDate).ThenBy(x => x.title).ToDictionary(x => x.title, x => x.releaseDate);
            foreach (var author in qeury)
            {
                Console.WriteLine($"{author.Key} -> {author.Value.ToString("dd.MM.yyyy")}");
            }
        }
    }
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string ISBN { get; set; }
        public DateTime releaseDate { get; set; }
        public double price { get; set; }

        public static Book Read(string input)
        {
            string[] data = input.Split();
            Book ans = new Book
            {
                title = data[0],
                author = data[1],
                publisher = data[2],
                releaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", null),
                ISBN = data[4],
                price = double.Parse(data[5])
            };
            return ans;
        }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
