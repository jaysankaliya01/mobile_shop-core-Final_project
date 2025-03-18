namespace mobile_shop_core_.Helpers.EmailHelper
{
    public interface IEmailService
    {
        Task SendEmail(string to, string subject, string body);
    }
}
