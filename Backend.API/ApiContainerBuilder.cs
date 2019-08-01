using Autofac;
using Backend.Services;

namespace Backend.API
{
    public class ApiContainerBuilder : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<ServicesContainerBuilder>();
            base.Load(builder);
        }
    }
}
