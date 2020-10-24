using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post bla bla bla...";
            var shortenedPost = post.Shorten(3);

            System.Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int>() {1, 7 ,4, 7, 23, 9};
            var max = numbers.Max();
            System.Console.WriteLine(max);

        }
    }
}
