using CustomAuth.Models.Providers;
using System.Security.Claims;

namespace CustomAuth.Services
{
    public class ClaimsFactory : IClaimsFactory
    {
        public IEnumerable<Claim> Create(Guid sessionId, IdentityUser user)
        {
            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Alias));
            claims.Add(new Claim(ClaimTypes.Sid, sessionId.ToString()));
            claims.Add(new Claim(ClaimTypes.GivenName, user.FirstName));
            claims.Add(new Claim(ClaimTypes.Surname, user.LastName));
            var roles = user.MemberOf.Select(r => new Claim(ClaimTypes.Role, r)).ToArray();
            claims.AddRange(roles);
            return claims;
        }
    }
}
