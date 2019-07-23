using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _orders;

        public Customer()
        {
            Id = -1;
            Name = "<Name>";
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            Id = id;
        }

        public Customer(string name)
            : this()
        {
            Name = name;
        }

        public Customer(int id, string name)
            : this(id)
        {
            // Id = id;
            Name = name;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public List<Order> Orders { get => _orders; set => _orders = value; }
    }
}
