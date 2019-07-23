using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();

            text.AddHyperlink("http://goole.com");
            // Height and width are inheritated from the base class PresentationObject
            text.Height = 20;
            text.Width = 40;
            // this are properties from the text object
            text.FontSize = 12;
            text.FontName = "Arial";

            text.Copy();
            text.Duplicate();


            Console.ReadKey();
        }
    }
}
