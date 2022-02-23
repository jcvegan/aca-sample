using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CustomAuth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingsController : Controller
    {
        [Authorize(AuthenticationSchemes = "custom")]
        [HttpGet(Name ="Greet superhero")]
        public IActionResult Get()
        {
            var name = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName)?.Value;

            return Ok(new
            {
                Message = $"Hello {name}!"
            });
        }
    }
}
