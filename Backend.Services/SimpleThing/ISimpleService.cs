using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Services.SimpleThing
{
    public interface ISimpleService
    {
        Task<string> GetValue();
        Task<List<string>> GetValues();
    }
}
