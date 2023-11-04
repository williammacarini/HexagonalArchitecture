using Domain.Adapters;
using Domain.Entities;

namespace Infra.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        public Task<IEnumerable<Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
