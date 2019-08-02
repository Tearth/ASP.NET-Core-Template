using Autofac;
using Backend.DataAccess;

namespace Backend.Services
{
    public class ServicesContainerBuilder : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(p => p.IsSubclassOf(typeof(ServiceBase)))
                .AsImplementedInterfaces();

            builder.RegisterModule<DataAccessContainerBuilder>();
            base.Load(builder);
        }
    }
}
