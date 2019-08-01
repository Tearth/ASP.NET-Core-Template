using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Services.SimpleThing
{
    public class SimpleService : ServiceBase, ISimpleService
    {
        public async Task<string> GetValue()
        {
            return await Task.Run(() => "value");
        }

        public async Task<List<string>> GetValues()
        {
            return await Task.Run(() => new List<string> { "value1", "value2" });
        }
    }
}
