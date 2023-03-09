using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HostedServiceChecker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HSTestController : ControllerBase
    {
        // GET: api/<HSTestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HSTestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        //[HttpGet()]
        //public string GetCunnectionChecker()
        //{
        //    return "OK";
        //}
        // POST api/<HSTestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HSTestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HSTestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
