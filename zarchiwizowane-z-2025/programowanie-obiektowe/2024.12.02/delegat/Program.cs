namespace delegat
{
    public class SmsNotifier
    {
        public void SendSms(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }

    public class EmailNotifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }

    public class PushNotifier
    {
        public void SendPushNotification(string message)
        {
            Console.WriteLine("Push Notification: " + message);
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
            if (_notify != null)
                _notify?.Invoke(message);
            else
                Console.WriteLine("Notification method not implemented");
        }
    }

    public delegate void NotificationHandler(string message);

    public static class Program
    {
        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("~~ Menu ~~");
            Console.WriteLine("1) Add Sms Notification");
            Console.WriteLine("2) Add Email Notification");
            Console.WriteLine("3) Add Push Notification");
            Console.WriteLine("4) Remove Sms Notification");
            Console.WriteLine("5) Remove Email Notification");
            Console.WriteLine("6) Remove Push Notification");
            Console.WriteLine("7) Send Notification");
            Console.WriteLine("8) Exit");
            Console.Write("Choose option: ");
        }

        private static string GetMessageFromConsole()
        {
            while (true)
            {
                Console.Write("Please enter the message: ");
                var message = Console.ReadLine();
                if (!string.IsNullOrEmpty(message))
                    return message;
            }
        }

        private static void Main()
        {
            var emailNotifier = new EmailNotifier();
            var pushNotifier = new PushNotifier();
            var smsNotifier = new SmsNotifier();
            var notificationManager = new NotificationManager();
            while (true)
            {
                try
                {
                    ShowMenu();
                    var option = byte.Parse(Console.ReadLine() ?? "");
                    if (option is < 1 or > 8)
                        throw new Exception("Invalid option: number is out of range");
                    switch (option)
                    {
                        case 1:
                            notificationManager.AddNotificationMethod(smsNotifier.SendSms);
                            Console.WriteLine("Notification method SMS added");
                            break;
                        case 2:
                            notificationManager.AddNotificationMethod(emailNotifier.SendEmail);
                            Console.WriteLine("Notification method Email added");
                            break;
                        case 3:
                            notificationManager.AddNotificationMethod(pushNotifier.SendPushNotification);
                            Console.WriteLine("Notification method PUSH added");
                            break;
                        case 4:
                            notificationManager.RemoveNotificationMethod(smsNotifier.SendSms);
                            Console.WriteLine("Notification method SMS removed");
                            break;
                        case 5:
                            notificationManager.RemoveNotificationMethod(emailNotifier.SendEmail);
                            Console.WriteLine("Notification method Email removed");
                            break;
                        case 6:
                            notificationManager.RemoveNotificationMethod(pushNotifier.SendPushNotification);
                            Console.WriteLine("Notification method PUSH notification removed");
                            break;
                        case 7:
                            notificationManager.SendNotification(GetMessageFromConsole());
                            break;
                        case 8:
                            return;
                        default:
                            throw new Exception("Invalid option");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid option: only numbers are allowed");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid option: number is too big or too small");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}