namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);
         
        }

        //02.Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            List<string> bookTitles = context
                .Books
                .AsEnumerable()
                .Where(x => x.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        //03.Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            List<string> bookTitles = context
                 .Books
                 .Where(x => x.EditionType == EditionType.Gold && x.Copies < 5000)
                 .OrderBy(x => x.BookId)
                 .Select(x => x.Title)
                 .ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        //04.Books by Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var bookTitlePrice = context
                .Books
                .Where(x => x.Price > 40)
                .Select(x => new
                {
                    Title = x.Title,
                    Price = x.Price
                })
                .OrderByDescending(x => x.Price)
                .ToList();

            foreach (var book in bookTitlePrice)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        //05.Not Released In
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var notReleasedBooks = context
                .Books
                .Where(x => x.ReleaseDate.Value.Year != year)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToList();

            return String.Join(Environment.NewLine, notReleasedBooks);
        }

        //06.Book Titles by Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.ToLower())
                .ToList();

            List<string> booksTitles = new List<string>();

            foreach (var category in categories)
            {
                var books = context
               .BooksCategories
               .Where(x => x.Category.Name.ToLower() == category)
               .Select(x => x.Book.Title)
               .ToList();

                booksTitles.AddRange(books);
            }

            return String.Join(Environment.NewLine, booksTitles.OrderBy(x => x));
        }

        //07.Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime dateParse = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context
                .Books
                .Where(x => x.ReleaseDate.Value.Date < dateParse)
                .OrderByDescending(x => x.ReleaseDate)
                .Select(x => new
                {
                    Title = x.Title,
                    Type = x.EditionType,
                    Price = x.Price
                })
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.Type} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        //08.Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authorFullName = context
                .Authors
                .Where(x => x.FirstName.EndsWith(input))
                .Select(x => new { FullName = x.FirstName + " " + x.LastName })
                .OrderBy(x => x.FullName)
                .ToList();

            return String.Join(Environment.NewLine, authorFullName.Select(x => x.FullName));
        }

        //09.Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            //Return the titles of book, which contain a given string. Ignore casing.
            //Return all titles in a single string, each on a new row, ordered alphabetically.

            var books = context.Books
                .Where(x => x.Title.ToLower().Contains(input.ToLower()))
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();

            return String.Join(Environment.NewLine, books);
        }

        //10.Book Search by Author
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var booksAuthors = context.Books
                .Where(x => x.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(x => x.BookId)
                .Select(x => new
                {
                    BookTitle = x.Title,
                    AuthorName = x.Author.FirstName + " " + x.Author.LastName
                })
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in booksAuthors)
            {
                sb.AppendLine($"{book.BookTitle} ({book.AuthorName})");
            }

            return sb.ToString();
        }

        //11.Count Books
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            int count = context.Books
                .Count(x => x.Title.Length > lengthCheck);

            return count;
        }

        //12.Total Book Copies
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var bookNumber = context.Authors
                .Select(x => new
                {
                    Author = x.FirstName + " " + x.LastName,
                    Copies = x.Books.Sum(x => x.Copies)
                })
                .OrderByDescending(x => x.Copies)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in bookNumber)
            {
                sb.AppendLine($"{item.Author} - {item.Copies}");
            }

            return sb.ToString();
        }

        //13.Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                .Select(x => new
                {
                    Category = x.Name,
                    Profit = x.CategoryBooks.Select(x => x.Book.Copies * x.Book.Price).Sum()
                })
                .OrderByDescending(x => x.Profit)
                .ThenBy(x => x.Category)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var category in categories)
            {
                sb.AppendLine($"{category.Category} ${category.Profit:f2}");
            }

            return sb.ToString();
        }

        //14.Most Recent Books
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var books = context
                                .Categories
                                .Select(x => new
                                {
                                    CategoryName = x.Name,
                                    Books = x.CategoryBooks
                                                .OrderByDescending(cb => cb.Book.ReleaseDate)
                                                .Take(3)
                                                .Select(x => new
                                                {
                                                    x.Book.Title,
                                                    x.Book.ReleaseDate.Value.Year
                                                })
                                })
                                .OrderBy(x => x.CategoryName)
                                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var category in books)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.Year})");
                }

            }
            return sb.ToString();
        }

        //15.Increase Prices
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.Where(x => x.ReleaseDate.Value.Year < 2010);

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        //16.Remove Books
        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books.Where(x => x.Copies < 4200).ToList();

            foreach (var book in books)
            {
                context.Books.Remove(book);
            }

            context.SaveChanges();

            return books.Count();
        }
    }
}
