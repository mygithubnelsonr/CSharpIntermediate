using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine($"{customer.Id}, {customer.Name}");

            customer = new Customer(1);
            Console.WriteLine($"{customer.Id}, {customer.Name}");

            customer = new Customer("John");
            Console.WriteLine($"{customer.Id}, {customer.Name}");

            customer = new Customer(2, "Bill");
            Console.WriteLine($"{customer.Id}, {customer.Name}");

            var order = new Order();
            customer.Orders.Add(order);


            Console.ReadKey();
        }
    }
}
