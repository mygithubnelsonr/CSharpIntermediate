using System;

namespace Interfaces_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChanel(new MailNotificationChanel());
            encoder.RegisterNotificationChanel(new SMSNotificationChanel());
            encoder.Encode(new Video());


            Console.WriteLine("Finish");
            Console.ReadKey();
        }
    }
}
