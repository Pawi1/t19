namespace delegat
{
    public class SmsNotifier
    {
        public void SendSms(string message)
        {
            Console.WriteLine("Send SMS: " + message);
        }
    }

    public class EmailNotifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Send Email: " + message);
        }
    }

    public class PushNotifier
    {
        public void SendPushNotification(string message)
        {
            Console.WriteLine("Send Push Notification: " + message);
        }
    }

    public class NotificationManager
    {
        private NotificationHandler? _notify;

        public void AddNotificationMethod(NotificationHandler handler)
        {
            _notify += handler;
        }

        public void RemoveNotificationMethod(NotificationHandler handler)
        {
            _notify -= handler;
        }

        public void SendNotification(string message)
        {
            _notify?.Invoke(message);
        }
    }

    public delegate void NotificationHandler(string message);

    public static class Program
    {
        private static void Main()
        {
            var emailNotifier = new EmailNotifier();
            var pushNotifier = new PushNotifier();
            var smsNotifier = new SmsNotifier();

        }
    }
}