namespace CinemaManagement.BL.Email
{
    public interface IEmailSender
    {
        void SendEmail(Message message);

    }
}