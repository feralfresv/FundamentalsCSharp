using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<Shape>();
            shape.Add(new Circule());
            shape.Add(new Rectangule());
            

            var canvas = new Canvas();
            canvas.DrawShapes(shape);


            Console.WriteLine("*************");

            shape.Add(new Triangule());
            canvas.DrawShapes(shape);

        }
    }
}
