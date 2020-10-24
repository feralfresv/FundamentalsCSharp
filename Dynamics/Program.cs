using System;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            dynamic name = "Fer";
            name = 10;

            //Example 2
            dynamic name1 = "Fer";
            name++; //Exception

            //Example 3
            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            //Example 4
            int i = 5;
            dynamic d = i;
            long l = d;


        }
    }
}
