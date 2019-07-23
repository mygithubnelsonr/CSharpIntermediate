using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add(1);                // boxing is happend because 1 valuetype is integer 
            list.Add("Mosh");           // string is a referenze type, boxing is not happend
            list.Add(DateTime.Today);   // DateTime is also an valuetype, boxing is happend

            // we loose type savety
            // var number = (int) list[1]; // forces an error

            var a = list[0];
            var b = list[1];
            var c = list[2];

            Console.WriteLine($"a={a.GetType()}, b={b.GetType()}, c={c.GetType()}");

            // with a generic list we are type savety and no boxing
            // because internally this list stores a list of integer not objects
            var anotherList = new List<int>();
            anotherList.Add(1);

            var names = new List<string>();
            names.Add("Mosh");

            Console.ReadKey();

        }
    }
}
