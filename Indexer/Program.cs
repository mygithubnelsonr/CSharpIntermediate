using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HTTPCookie();

            cookie["name"] = "Mosh";
            cookie.Expire = new DateTime(2019, 07, 18);

            Console.WriteLine($"cookie name = {cookie["name"]}, expire date = {cookie.Expire}");

            Console.ReadKey();
        }
    }
}
