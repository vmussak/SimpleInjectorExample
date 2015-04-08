using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using SimpleInjectorExample.Business;
using SimpleInjectorExample.Business.Concrete;
using SimpleInjectorExample.Repository.Concrete;

namespace SimpleInjectorExample.IOC
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            //Registrando as Implementações
            container.Register<IClientService, ClientService>();
            container.Register<IClientRepository, ClientRepository>();

            container.Verify();
            return container;
        }
    }
}
