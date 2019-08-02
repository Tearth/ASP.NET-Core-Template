using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Services.SimpleThing;
using Microsoft.AspNetCore.Mvc;

namespace Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISimpleService _simpleService;

        public ValuesController(ISimpleService simpleService)
        {
            _simpleService = simpleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<string>>> Get()
        {
            return await _simpleService.GetValues();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return await _simpleService.GetValue();
        }
    }
}
