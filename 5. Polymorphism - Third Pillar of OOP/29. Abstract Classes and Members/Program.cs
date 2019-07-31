using System;

namespace Abstract_Classes_and_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            // because the shape class is declared as abstract we can not make an instance of it
            // Error CS0144
            // Cannot create an instance of the abstract class or interface 'Shape'	Abstract Classes and Members

            // var shape = new Shape();


            var circle = new Circle();
            circle.Draw();
            circle.Copy();

            var rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Select();

            Console.ReadKey();
        }
    }
}
