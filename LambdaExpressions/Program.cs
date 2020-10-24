using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expressions

            Func<int, int> square = square => square * square;
            Console.WriteLine("Example 1: " + square(5));

            const int factor = 5;
            Func<int, int> multipler = n => n * factor;
            System.Console.WriteLine("Example 2: " + multipler(10));

            var getBoooks = new BookRepository().GetBook();

            //var cheaper = getBoooks.FindAll(CheaperThan10Dollar);
            var cheaper = getBoooks.FindAll(b => b.Price < 6);

            foreach (var item in cheaper)
            {
                System.Console.WriteLine(item.Title);
            }
            
        }

        static bool CheaperThan10Dollar(Book book)
        {
            return book.Price < 10;
        }
    }
}
