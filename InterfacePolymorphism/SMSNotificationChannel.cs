namespace InterfacePolymorphism
{
    public class SMSNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sensign SMS...");
        }
    }
}
