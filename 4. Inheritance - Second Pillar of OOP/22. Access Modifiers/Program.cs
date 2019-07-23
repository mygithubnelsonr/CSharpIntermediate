using Amazon;
using System;

namespace Access_Modifiers
{
    class Program
    {
        //public class GoldCustomer : Customer
        //{
        //    // if Accesss Modifier is Customer.CalculateRating private
        //    // the function CalculateRating is not visible
        //    // if the Access Modifier is protected we can access the function
        //    public void OfferVoucher()
        //    {   // if the customer calss is changed e.g. rename the CalculateRating method an raises
        //        // Error CS0103  The name 'CalculateRating' does not exist in the current context
        //        // var rating = CalculateRating(excludeOrders: true);

        //    }
        //}

        static void Main(string[] args)
        {
            var customer = new Customer();

            // we can not access Amazon.RateCalculator because it's protected (internal)
            // Amazon.RateCalculator calculator = new Amazon.RateCalculator();

            customer.Promote();

            Console.WriteLine("customer Promoted");


            Console.ReadKey();
        }
    }
}
