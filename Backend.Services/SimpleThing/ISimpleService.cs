using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Services.Dtos;

namespace Backend.Services.SimpleThing
{
    public interface ISimpleService
    {
        Task<TestDto> GetValue();
        Task<List<TestDto>> GetValues();
    }
}
