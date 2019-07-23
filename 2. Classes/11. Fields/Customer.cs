using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        // with the readonly modifier Orders can only initialized
        // once even in the Field declaration or in the default constructor
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(string name)
        {
            Name = name;
        }

        public Customer(int id, string name)
            : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            // if List<Order> is declared as readonly this command forces an error
            //Orders = new List<Order>();

            // ...
        }

    }
}
