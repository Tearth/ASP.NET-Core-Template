using Autofac;

namespace Backend.Services
{
    public class ServicesContainerBuilder : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(p => p.IsSubclassOf(typeof(ServiceBase)))
                .AsImplementedInterfaces();

            base.Load(builder);
        }
    }
}
