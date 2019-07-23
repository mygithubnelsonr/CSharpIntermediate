using System;

namespace Access_Modifiers
{
    // rename Customer class instate deleting
    public class CustomerClassDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            // if List<Order> is declared as readonly this command forces an error
            //Orders = new List<Order>();
            // ...

            Console.WriteLine("Promote class changed.");
            var rating = RatingCalculate(excludeOrders: true);

            if (rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level2");

        }

        // private int CalculateRating(bool excludeOrders)
        // protected int CalculateRating(bool excludeOrders)
        protected int RatingCalculate(bool excludeOrders)
        {
            return 0;
        }

    }
}
