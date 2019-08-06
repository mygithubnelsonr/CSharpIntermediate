using System;

namespace Interfaces_and_Polymorphism
{
    public class SMSNotificationChanel : INotificationChanel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending an SMS...");
        }
    }
}
