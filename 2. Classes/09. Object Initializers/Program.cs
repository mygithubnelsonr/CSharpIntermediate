using System;

namespace Object_Initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize an objects parameter with one or more values
            var person = new Person
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Nelson",
                Birthday = new DateTime(1954, 01, 09)
            };

            Console.WriteLine($"{person.Id}, {person.FirstName}, {person.LastName}, {person.Birthday}");

            Console.ReadKey();
        }
    }
}
