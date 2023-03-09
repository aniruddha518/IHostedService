using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HostedServiceChecker.Controllers
{
    [Route("api2")]
    [ApiController]
    public class abc : ControllerBase
    {
        [HttpGet("/GetCunnectionChecker", Name = "GetCunnectionChecker")]
        public string GetCunnectionChecker()
        {
            return "OK";
        }
    }
}
