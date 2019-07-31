using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                // we do not longer need this switch block after we create
                // the overload of the circle and the rectangle class
                //switch (shape.Type)
                //{
                //    case ShapeType.Circle:
                //        Console.WriteLine("Draw a Circle");
                //        break;

                //    case ShapeType.Rectangle:
                //        Console.WriteLine("Draw a Rectasngle");
                //        break;
                //}

                // polymorphism
                shape.Draw();

            }
        }
    }
}
