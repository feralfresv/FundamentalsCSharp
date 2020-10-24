using System;
namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newPoint)
        {
            if (newPoint == null)
                throw new ArgumentNullException("Is better get System.ArgumentNullException than System.NullReferenceException");
            Move(newPoint.X, newPoint.Y);
        }
    }
}
