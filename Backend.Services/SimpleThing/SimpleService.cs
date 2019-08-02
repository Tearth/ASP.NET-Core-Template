using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.DataAccess;
using Backend.DataAccess.Context;
using Backend.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Backend.Services.SimpleThing
{
    public class SimpleService : ServiceBase, ISimpleService
    {
        private DatabaseContext _databaseContext;

        public SimpleService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> GetValue()
        {
            return (await _databaseContext.TestModels.FirstOrDefaultAsync()).Name ?? "none";
        }

        public async Task<List<string>> GetValues()
        {
            return _databaseContext.TestModels.Select(p => p.Name).ToList();
        }
    }
}
