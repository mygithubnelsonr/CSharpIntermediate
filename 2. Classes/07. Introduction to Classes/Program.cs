using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Intermediate
{
    class Program
    {
        public class Person
        {
            public string Name;

            public Person()
            {

            }

            public Person(string name)
            {
                Name = name;
            }

            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;
                return person;
            }

            public void Introduce(string to)
            {
                Console.WriteLine($"Hi {to}, I am {Name}");

            }
        }

        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Mosh";
            person.Introduce("Bob");

            person = new Person("John");
            person.Introduce("Sam");

            // this make no sense to create an object to get
            // an object back to call an method
            // after make the Pares methode static we get an error
            // Error CS0176  Member 'Program.Person.Parse(string)' 
            // cannot be accessed with an instance reference; qualify it with
            // a type name instead Introduction to Classes

            person = new Person();
            //var p = person.Parse("Hank");
            //p.Introduce("Tom");

            // so this is why we use a static method
            var p2 = Person.Parse("Hank");
            p2.Introduce("Tom");

            Console.ReadKey();

        }
    }
}
