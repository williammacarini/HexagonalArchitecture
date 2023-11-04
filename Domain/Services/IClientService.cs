using Domain.Entities;

namespace Domain.Services
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllAsync();

        Task AddAsync(Client client);
    }
}
