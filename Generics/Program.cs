using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "111", Title = "C# Advanced" };

            // var numbers = new List();
            // numbers.Add(10);
            // var books = new BookList();
            // books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictonary = new GenericDictionary<string, Book>();
            dictonary.Add("2222", new Book());


            var number = new Nullable<int>(0);
            System.Console.WriteLine("Has Value: " + number.HasValue);
            System.Console.WriteLine("Value is: " + number.GetValueOrDefault());
        }
    }
}
