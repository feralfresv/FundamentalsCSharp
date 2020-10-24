using System;

namespace AccessModifiers
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var person = new Personas();
            person.SetBirthDate(new DateTime(1994,03,11));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
