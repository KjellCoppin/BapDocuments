//namespace ex1
//{
//    public interface INotificationServer
//    {
//        void Attach(ISubscriber subscriber);
//        void Detach(ISubscriber subscriber);
//        void Notify();
//    }
//    public class NotificationServer
//    {
//        private List<ISubscriber> _subscribers = new List<ISubscriber>();
//        public void Attach(ISubscriber subscriber) => _subscribers.Add(subscriber);
//        public void Detach(ISubscriber subscriber) => _subscribers.Remove(subscriber);
//        public void Notify(string notificationText)
//        {
//            foreach(ISubscriber subscriber in _subscribers)
//            {
//                subscriber.Update(notificationText);
//            }
//        }
//    }

//    public interface ISubscriber
//    {
//        void Update(string notificationText);
//    }
//    public class Subscriber : ISubscriber
//    {
//        public void Update(string notificationText)
//        {
//            Console.WriteLine($"new notification: ${notificationText}");
//        }
//    }
//}
