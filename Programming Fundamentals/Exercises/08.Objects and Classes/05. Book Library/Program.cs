using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05._Book_Library
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
            //price. 


            int n = int.Parse(Console.ReadLine());
            Library lib = new Library();
            lib.Books = new List<Book>(); 
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Book singleBook = new Book();    
                singleBook.title = input[0];
                singleBook.author = input[1];
                singleBook.publisher = input[2];
                singleBook.date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture); ;
                singleBook.ISBN = input[4];
                singleBook.price = double.Parse(input[5]);

                
                lib.Books.Add(singleBook); 
            }

            var dict = new SortedDictionary<string, double>();

            

            foreach (var book in lib.Books)
            {
                
                if (dict.ContainsKey(book.author))
                {
                    dict[book.author] += book.price;
                }
                else
                {
                    dict.Add(book.author, book.price);
                }

            }

            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value :F2}");
            }

        }
    }
}
