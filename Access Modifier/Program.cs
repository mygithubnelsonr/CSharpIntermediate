using System;

namespace Access_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthday(new DateTime(1954, 01, 09));
            Console.WriteLine(person.GetBirthdate().ToShortDateString());



            Console.ReadKey();
        }
    }
}
