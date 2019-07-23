using System;
using System.Collections;

namespace Upcasting_and_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample1();

            // Sample2();

            // Sample3();

            Console.ReadKey();
        }

        static void Sample1()
        {
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine($"text width is {text.Width}");
        }

        static void Sample2()
        {
            // all stream objects are derived from the System.IO.Stream class
            //StreamReader streamReader = new StreamReader(new FileStream());
            //StreamReader streamReader = new StreamReader(new MemoryStream());

            var list = new ArrayList();

            // the add method accept an object of any type
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());

            foreach (var obj in list)
            {
                Console.WriteLine($"{obj}");
            }
        }

        static void Sample3()
        {
            // downcasting an object

            Shape shape = new Text();
            // the shape object does not have the properties from Text

            Text text = (Text)shape;
            // the text object have all properties from shape and text

        }
    }
}
