using System;

namespace Constructors_and_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // the base (Vehicle) class of the car class is allways initialized first
            var car = new Car("XYZ 32-476");

            Console.ReadKey();
        }
    }
}
