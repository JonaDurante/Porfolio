using MailKit.Security;
using MimeKit;
using PorfolioWeb.Dto;

namespace PorfolioWeb.Services
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(MailRequestDto mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_configuration["MailSettings:Mail"]);
            email.To.Add(MailboxAddress.Parse(_configuration["MailSettings:Mail"]));
            email.Subject = mailRequest.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = $"<p>From: {mailRequest.Name} ({mailRequest.FromEmail})</p><p>{mailRequest.Body}</p>";
            email.Body = builder.ToMessageBody();

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            var host = _configuration["MailSettings:Host"];
            var portString = _configuration["MailSettings:Port"];
            var port = !string.IsNullOrEmpty(portString) ? int.Parse(portString) : 25;
            var mail = _configuration["MailSettings:Mail"];
            var password = _configuration["MailSettings:Password"];

            await smtp.ConnectAsync(host, port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(mail, password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
