using System;

namespace Constructors_and_Inheritance
{
    public class Car : Vehicle
    {
        // the base (Vehicle) class of the car class is allways initialized first
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized with {0}.", registrationNumber);
        }
    }
}
