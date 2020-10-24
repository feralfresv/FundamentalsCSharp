namespace InterfacePolymorphism
{
    public class XboxNotificacionChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending XBOX...");
        }
    }
}
