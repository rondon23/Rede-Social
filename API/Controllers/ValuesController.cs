using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        //GET api/value/5
        [HttpGet("{id}")]
        public ActionResult<string> Get()
        {
            return "value";
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete()
        {
            
        }
    }
}