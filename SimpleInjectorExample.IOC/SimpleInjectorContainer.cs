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

            /*var serviceAssembly = typeof(ClientService).Assembly;
            var repositoryAssembly = typeof(ClientRepository).Assembly;

            var serviceRegistrations =
                from type in serviceAssembly.GetExportedTypes()
                where type.GetInterfaces().Any()
                select new { Service = type.GetInterfaces().Single(), Implementation = type };

            var repositoryRegistrations =
                from type in repositoryAssembly.GetExportedTypes()
                where type.GetInterfaces().Any()
                select new { Service = type.GetInterfaces().Single(), Implementation = type };

            foreach (var reg in serviceRegistrations)
            {
                container.Register(reg.Service, reg.Implementation, Lifestyle.Transient);
            }

            foreach (var reg in repositoryRegistrations)
            {
                container.Register(reg.Service, reg.Implementation, Lifestyle.Transient);
            }*/

            container.Verify();
            return container;
        }
    }
}
