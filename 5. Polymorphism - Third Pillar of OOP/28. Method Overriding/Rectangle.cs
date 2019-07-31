using System;

namespace Method_Overriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }
}
