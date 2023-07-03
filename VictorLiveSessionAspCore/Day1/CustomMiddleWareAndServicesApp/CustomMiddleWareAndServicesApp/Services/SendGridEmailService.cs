namespace CustomMiddleWareAndServicesApp.Services
{
    public class SendGridEmailService : IEmailService
    {

        public SendGridEmailService() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SendGrid servcie Created");
            Console.ResetColor();

        }
        public Task SendEmail(string detail)
        {

            return Task.Run(() => {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"SendGrid servcies sending{detail} ");
                Console.ResetColor();

            });
           
        }

        public Task SendEmailDiffertn()
        {
            throw new NotImplementedException();
        }
    }
}
