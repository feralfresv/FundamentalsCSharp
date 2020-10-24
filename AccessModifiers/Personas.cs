using System;

namespace AccessModifiers
{
    partial class Program
    {
        class Personas
        {
            private DateTime _birthdate;

            public void SetBirthDate(DateTime birthdate)
            {
                this._birthdate = birthdate;
            }
            public DateTime GetBirthDate()
            {
                return _birthdate;
            }
        }
    }
}
