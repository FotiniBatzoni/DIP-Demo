namespace DemoLibrary
{
    public interface IMessageSender
    {
        void SendEmail(IPerson person, string message);
    }
}