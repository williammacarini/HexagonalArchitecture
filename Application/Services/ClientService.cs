using Domain.Adapters;
using Domain.Entities;
using Domain.Services;

namespace Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IEmailAdapter _emailAdapter;
        private readonly IClientRepository _clientRepository;

        public ClientService(IEmailAdapter emailAdapter, IClientRepository clientRepository)
            => (_emailAdapter, _clientRepository) 
            = (emailAdapter, clientRepository);

        public async Task AddAsync(Client client)
        {
            await _clientRepository.InsertAsync(client);
            await _emailAdapter.SendEmailAsync(client.Email, "test@gmail.com", "test", "body test");
        }

        public Task<IEnumerable<Client>> GetAllAsync()
            => _clientRepository.GetAllAsync();
    }
}
