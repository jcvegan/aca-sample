using CustomAuth.Models.Providers;
using System.Security.Claims;

namespace CustomAuth.Services
{
    public interface IClaimsFactory
    {
        IEnumerable<Claim> Create(Guid sessionId, IdentityUser user);
    }
}
