using Domain.Entities;

namespace Domain.Adapters
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task InsertAsync(Client client);
    }
}
