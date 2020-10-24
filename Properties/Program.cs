using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1994, 03, 11));
            Console.WriteLine(person.Age);
        }
    }
}
