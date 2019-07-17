using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        // CTOR
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // signature of a method
        // Name + Type of parameters
        // in this case Name=Move, Types are Integer
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // overloading a method
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("Point.newLocation");

            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }

        public void Move(Point newLocation, int speed) { }

    }
}
