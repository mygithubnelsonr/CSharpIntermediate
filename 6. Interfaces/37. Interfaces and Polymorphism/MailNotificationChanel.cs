using System;

namespace Interfaces_and_Polymorphism
{
    public class MailNotificationChanel : INotificationChanel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending email...");
        }
    }
}
