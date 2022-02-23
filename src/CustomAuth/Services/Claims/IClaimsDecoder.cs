using System.Security.Claims;

namespace CustomAuth.Services
{
    public interface IClaimsDecoder
    {
        IEnumerable<Claim> Decode(string token);
    }
}
