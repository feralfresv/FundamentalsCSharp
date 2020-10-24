using System;
namespace MethodOverriding
{

    public class Circule : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circule");
        }
    }

    public class Rectangule : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangule");
        }
    }

    public class Triangule : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a triangule");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}
