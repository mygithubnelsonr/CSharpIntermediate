using System;

namespace Method_Overriding
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }
}
