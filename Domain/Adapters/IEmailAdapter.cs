namespace Domain.Adapters
{
    public interface IEmailAdapter
    {
        Task SendEmailAsync(string from, string to, string subject, string body);
    }
}
