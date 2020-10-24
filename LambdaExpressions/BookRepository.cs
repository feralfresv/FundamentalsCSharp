using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBook()
        {
            return new List<Book>
            {
                new Book() {Title = "First", Price= 5},
                new Book() {Title = "Second", Price= 7},
                new Book() {Title = "Thrid", Price= 14}
            };
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
