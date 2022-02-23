using CustomAuth.Models.Providers;

namespace CustomAuth.Providers
{
    public class IdentityProvider : IIdentityProvider
    {
        private readonly IEnumerable<IdentityUser> _users;
        public IdentityProvider(IEnumerable<IdentityUser> users)
        {
            _users = users;
        }
        public bool Exists(string username)
        {
            return _users.Any(x => x.Username == username);
        }

        public IdentityUser? Get(string username)
        {
            return _users.FirstOrDefault(x => x.Username.ToLowerInvariant() == username.ToLowerInvariant());
        }
    }
}
