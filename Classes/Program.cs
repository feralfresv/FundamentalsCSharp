using System;

namespace Classes
{
    class Program
    {        
        static void Main(string[] args)
        {
            var person = Person.ParseName("Fernando");
            person.Introduce("Ana Pau");                        
        }
    }
}
