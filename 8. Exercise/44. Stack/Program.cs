using System;

namespace Stack
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            int ini = 0;
            int max = 6;

            for (int i = ini; i <= max; i++)
                stack.Push(i);

            for (int i = ini; i <= max; i++)
                Console.WriteLine(stack.Pop());


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
