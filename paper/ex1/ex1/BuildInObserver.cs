namespace ex1
{
    public class NotificationServer
    {
        public delegate void NotificationHandler(string notificationText);
        public event NotificationHandler? OnNotification;

        public void SendNotification(string notificationText)
        {
            OnNotification?.Invoke(notificationText);
        }
    }

    public class Phone
    {
        public void Subscribe(NotificationServer server)
        {
            server.OnNotification += ReceiveNotification;
        }
        private void ReceiveNotification(string notificationText) 
        {
            Console.WriteLine($"New notification: ${notificationText}");
        }
    }
}
