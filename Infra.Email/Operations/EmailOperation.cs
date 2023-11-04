using Domain.Adapters;

namespace Infra.Email.Operations
{
    public class EmailOperation : IEmailAdapter
    {
        public Task SendEmailAsync(string from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
