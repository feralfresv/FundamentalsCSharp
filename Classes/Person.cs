namespace Classes
{
    class Person
    {
        public string Name;

        public void Introduce(string name)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", name, Name);
        }

        public static Person ParseName(string arseName)
        {
            var person = new Person();
            person.Name = arseName;
            return person;
        } 
    }
}
