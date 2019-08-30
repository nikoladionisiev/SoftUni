using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _06._Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            //author
            //publisher
            //release date (in dd.MM.yyyy format)
            //ISBN -number
            //price

            int n = int.Parse(Console.ReadLine());

            Library lib = new Library();
            lib.books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                Book singleBook = new Book();

                string[] input = Console.ReadLine().Split();

                singleBook.title = input[0];
                singleBook.author = input[1];
                singleBook.publisher = input[2];
                singleBook.date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                singleBook.ISBN = input[4];
                singleBook.price = double.Parse(input[5]);

                lib.books.Add(singleBook);

            }
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            SortedDictionary<string, DateTime> data = new SortedDictionary<string, DateTime>();

            foreach (Book book in lib.books)
            {
                data[book.title] = book.date;
            }

            foreach (var entry in data.Where(x => x.Value > date).OrderBy(x => x.Value))
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
