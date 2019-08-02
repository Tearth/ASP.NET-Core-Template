using Autofac;
using Backend.DataAccess.Context;
using Backend.DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace Backend.DataAccess
{
    public class DataAccessContainerBuilder : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>();
            //builder.RegisterType<DatabaseContext>()
            //    .WithParameter("options", DatabaseContextConfiguration.Configure())
            base.Load(builder);
        }
    }
}
