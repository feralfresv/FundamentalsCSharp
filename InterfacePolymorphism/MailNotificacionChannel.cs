namespace InterfacePolymorphism
{
    public class MailNotificacionChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending mail...");
        }
    }
}
