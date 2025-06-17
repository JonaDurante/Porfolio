using PorfolioWeb.Dto;

namespace PorfolioWeb.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequestDto mailRequest);
    }
}
