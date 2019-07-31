using System;

namespace Abstract_Classes_and_Members
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // abstract methods have no body!
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape to clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
