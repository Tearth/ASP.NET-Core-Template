using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task Post([FromBody] string value)
        {

        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

        }
    }
}
