using CustomAuth.Models.Auth;
using CustomAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuth.Controllers
{
    public class AuthController : Controller
    {
        private readonly ISessionService _sessionService;

        public AuthController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        [HttpPost("authorize/token")]
        [Produces("application/json")]
        public IActionResult SignIn([FromForm]SignInModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            try
            {
                var userSession = _sessionService.CreateSession(model.Username, model.Password);

                return Ok(userSession);
            }
            catch (Exception exception)
            {
                return StatusCode(401, "Cannot authenticate with provided credentials");
            }
        }
    }
}
