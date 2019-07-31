using NClap;
using System;

namespace Interfaces_and_Testability
{
    class Program
    {
        static void Main(string[] args)
        {

            // check out the use of NClap
            MyProgramArguments programArgs;
            if (!CommandLineParser.TryParse(args, out programArgs))
            {
                return;
            }

            return;

            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };

            orderProcessor.Process(order);


            Console.ReadKey();

        }
    }
}
