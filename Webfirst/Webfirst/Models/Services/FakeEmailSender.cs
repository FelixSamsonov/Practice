using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Webfirst.Services
{
    public class FakeEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask; 
        }
    }
}
