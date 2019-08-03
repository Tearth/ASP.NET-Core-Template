using AutoMapper;
using Backend.DataAccess.Models;
using Backend.Services.Dtos;

namespace Backend.Services
{
    public class ServicesMapperProfile : Profile
    {
        public ServicesMapperProfile()
        {
            CreateMap<TestDto, TestModel>().ReverseMap();
        }
    }
}
