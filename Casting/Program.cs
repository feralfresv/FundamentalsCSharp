using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            UpCasting();
            DownCasting();

        }

        public static void UpCasting()
        {
            #region E.g 1
            var text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); //100;
            #endregion

            var list = new ArrayList();
            list.Add(1);
            list.Add("Fernando");
            list.Add(new Text());

            var list2 = new List<Shape>();
        }

        public static void DownCasting()
        {
            Shape shape = new Text();
            Text text = (Text)shape;

        }
    }
}
