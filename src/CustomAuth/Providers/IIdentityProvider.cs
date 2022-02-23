using CustomAuth.Models.Providers;

namespace CustomAuth.Providers
{
    public interface IIdentityProvider
    {
        bool Exists(string username);
        IdentityUser? Get(string username);
    }
}
