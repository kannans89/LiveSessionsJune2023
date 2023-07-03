namespace CustomMiddleWareAndServicesApp.Services
{
    public interface IEmailService
    {
       Task SendEmail(string detail);

        Task SendEmailDiffertn();
    }
}
