using System;
using System.Collections.Generic;
using SimpleInjectorExample.Business;
using SimpleInjectorExample.Business.Models;

namespace SimpleInjectorExample.Repository.Concrete
{
    public class ClientRepository : IClientRepository
    {
        public IEnumerable<Client> Get()
        {
            for (var i = 0; i < 20; i++)
                yield return new Client(i, "First Name", "Last Name", i, DateTime.Now);
        }
    }
}
