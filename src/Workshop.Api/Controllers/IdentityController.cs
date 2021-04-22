using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Workshop.Api.Controllers
{
    [Route("[controller]")]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(User.Claims.Select(x => new {x.Type, x.Value}));
        }
    }
}
