using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1954, 01, 09));

            // we dont need this no longer
            //person.Birthdate = new DateTime(1954, 01, 09);

            Console.WriteLine($"Birthdate is {person.Birthdate.ToShortDateString()}");
            Console.WriteLine($"the age is {person.Age} years.");



            Console.ReadKey();
        }
    }
}
