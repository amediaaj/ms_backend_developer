
namespace Patterns{
    public enum Channel
    {
        Email,
        SMS
    }

    public class NotificationFactory
    {
        public INotification CreateNotification(Channel channel)
        {
            if (channel == Channel.Email)
            {
                return new EmailNotification();
            }
            else if (channel == Channel.SMS)
            {
                return new SMSNotification();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
