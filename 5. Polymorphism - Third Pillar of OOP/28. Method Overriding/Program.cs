using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            shapes.Add(new Circle { Width = 100, Height = 100 });
            shapes.Add(new Rectangle());
            // just added a new class triangle derived from shape
            // and add it to the shape list
            shapes.Add(new Triangle());
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            Console.ReadKey();
        }
    }
}
