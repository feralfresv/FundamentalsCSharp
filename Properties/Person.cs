using System;

namespace Properties
{
    class Person
    {
        public DateTime Birthdate { get; private set; }
        public int Age
        {
            get 
            {
                var timeSpan = DateTime.Now - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        
        public Person(DateTime bithdate)
        {
            this.Birthdate = bithdate;
        }

    }
}
