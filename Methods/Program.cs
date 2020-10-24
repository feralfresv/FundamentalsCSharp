using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
                System.Console.WriteLine(num);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Conversion failed int.Parse");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                System.Console.WriteLine(result);
            else
                System.Console.WriteLine("Conversion failed int.TryParse");
        }

        static void Calculator()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4));
            System.Console.WriteLine(calculator.Add(10, 5, 599, 3));
            System.Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                point.Move(40, 80);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("An unexpeccted error occured");
            }
        }
    }
}
