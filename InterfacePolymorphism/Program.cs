using System;

namespace InterfacePolymorphism
{
    class Program
    {        
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificacionChannel());
            encoder.RegisterNotificationChannel(new SMSNotificationChannel());
            encoder.RegisterNotificationChannel(new XboxNotificacionChannel());
            encoder.Encode(new Video());
        }
    }
}
