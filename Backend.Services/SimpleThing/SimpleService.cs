using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Backend.DataAccess;
using Backend.DataAccess.Context;
using Backend.DataAccess.Models;
using Backend.Services.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Backend.Services.SimpleThing
{
    public class SimpleService : ServiceBase, ISimpleService
    {
        private DatabaseContext _databaseContext;
        private IMapper _mapper;

        public SimpleService(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public async Task<TestDto> GetValue()
        {
            var model = await _databaseContext.TestModels.FirstOrDefaultAsync();
            return _mapper.Map<TestDto>(model);
        }

        public async Task<List<TestDto>> GetValues()
        {
            var models = await _databaseContext.TestModels.ToListAsync();
            return _mapper.Map<List<TestDto>>(models);
        }
    }
}
