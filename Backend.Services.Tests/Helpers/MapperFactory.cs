#pragma warning disable 618

using AutoMapper;

namespace Backend.Services.Tests.Helpers
{
    public static class MapperFactory
    {
        public static IMapper Create()
        {
            Mapper.Reset();
            Mapper.Initialize(config => config.AddProfile<ServicesMapperProfile>());

            return Mapper.Instance;
        }
    }
}
