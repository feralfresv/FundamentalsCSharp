using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query Operators
            var listBooks2 =
            from b in books
            where b.Price < 10
            orderby b.Title
            select b.Title;

            //LIQN Extension Methods
            var listBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            var book1 = books.SingleOrDefault(b => b.Title == "ASP.NET");
            var book2 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            var book3 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            var book4 = books.Skip(2).Take(3);
            var book5 = books.Count();
            var book6 = books.Max(b => b.Price);
            var book7 = books.Min(b => b.Price);
            var book8 = books.Sum(b => b.Price);
            var book9 = books.Average(b => b.Price);



            System.Console.WriteLine(book9);


            

        }
    }
}
