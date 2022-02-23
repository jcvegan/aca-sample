using System.Security.Claims;

namespace CustomAuth.Services
{
    public interface ITokenFactory
    {
        string Create(IEnumerable<Claim> claim);
    }
}
