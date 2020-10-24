using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            System.Console.WriteLine(date.GetValueOrDefault());
            System.Console.WriteLine(date.HasValue);
            System.Console.WriteLine("-------------------------------1");
            //System.Console.WriteLine(date.Value);

            DateTime? date1 = new DateTime(2014,12,30);
            DateTime date2 = date1.GetValueOrDefault();
            DateTime? date3 = date2;
            System.Console.WriteLine(date3);
            System.Console.WriteLine("-------------------------------2");

            DateTime? date4 = null;
            DateTime date5 = date4 ?? DateTime.Today; //If date has a value ??else date_today
            DateTime date6 = (date4 != null) ? date4.GetValueOrDefault() : DateTime.Today;

            System.Console.WriteLine(date6);
            System.Console.WriteLine("-------------------------------3");


        }
    }
}
