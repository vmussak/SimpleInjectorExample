using System.Collections.Generic;
using SimpleInjectorExample.Business.Models;

namespace SimpleInjectorExample.Business
{
    public interface IClientRepository
    {
        IEnumerable<Client> Get();
    }
}
