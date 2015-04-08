using System.Collections.Generic;
using SimpleInjectorExample.Business.Models;

namespace SimpleInjectorExample.Business
{
    public interface IClientService
    {
        IEnumerable<Client> Get();
    }
}
