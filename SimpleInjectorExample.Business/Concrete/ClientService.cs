using System.Collections.Generic;
using SimpleInjectorExample.Business.Models;

namespace SimpleInjectorExample.Business.Concrete
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;
        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Client> Get()
        {
            return _repository.Get();
        }
    }
}