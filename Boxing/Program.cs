using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Fernando");
            list.Add(DateTime.Now);

            var anotherList = new List<int>();
            anotherList.Add(123);
            
            var names = new List<string>();
            names.Add("ABC");

        }
    }
}
