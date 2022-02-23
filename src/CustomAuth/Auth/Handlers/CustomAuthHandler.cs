using CustomAuth.Auth.Options;
using CustomAuth.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace CustomAuth.Auth.Handlers
{
    public class CustomAuthHandler : AuthenticationHandler<CustomAuthSchemeOptions>
    {
        private readonly ITokenValidator _tokenValidator;
        private readonly IClaimsDecoder _claimsDecoder;
        
        public CustomAuthHandler(IOptionsMonitor<CustomAuthSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, ITokenValidator tokenValidator, IClaimsDecoder claimsDecoder) : base(options, logger, encoder, clock)
        {
            _tokenValidator = tokenValidator;
            _claimsDecoder = claimsDecoder;
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var endpoint = Context.GetEndpoint();

            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
                return Task.FromResult(AuthenticateResult.NoResult());

            if (!Request.Headers.ContainsKey("Authorization"))
                return Task.FromResult(AuthenticateResult.Fail("Missing header"));

            var token = Request.Headers["Authorization"].ToString()
            .Replace("bearer ", "", StringComparison.InvariantCultureIgnoreCase);

            var isTokenValid = _tokenValidator.IsValid(token);

            if (!isTokenValid)
                return Task.FromResult(AuthenticateResult.Fail("Invalid token"));

            var claims = _claimsDecoder.Decode(token);

            var identity = new ClaimsIdentity(claims, "custom");

            var principal = new ClaimsPrincipal(identity);

            return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(principal, "custom")));
        }
    }
}
