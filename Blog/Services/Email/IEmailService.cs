using System.Threading.Tasks;

namespace Blog.Services.Email
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string message);
    }
}
