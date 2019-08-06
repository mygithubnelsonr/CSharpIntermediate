using System.Collections.Generic;

namespace Interfaces_and_Polymorphism
{
    public class VideoEncoder
    {
        // using the INotificationChanel Interface we not need this
        // private readonly MailService _mailservice;

        private readonly IList<INotificationChanel> _notificationChanels;

        public VideoEncoder()
        {
            //_mailservice = new MailService();
            _notificationChanels = new List<INotificationChanel>();


        }

        public void Encode(Video video)
        {
            // video encoding logic

            //_mailservice.Send(new Mail());

            foreach (var chanel in _notificationChanels)
                chanel.Send(new Message());
        }

        public void RegisterNotificationChanel(INotificationChanel chanel)
        {
            _notificationChanels.Add(chanel);
        }
    }
}
