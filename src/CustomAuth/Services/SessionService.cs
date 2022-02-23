using CustomAuth.Models.Services;
using CustomAuth.Providers;

namespace CustomAuth.Services
{
    public class SessionService : ISessionService
    {

        private readonly IIdentityProvider _identityProvider;
        private readonly IClaimsFactory _claimsFactory;
        private readonly ITokenFactory _tokenFactory;
        public SessionService(IIdentityProvider identityProvider, IClaimsFactory claimsFactory, ITokenFactory tokenFactory)
        {
            _identityProvider = identityProvider;
            _claimsFactory = claimsFactory;
            _tokenFactory = tokenFactory;
        }

        public SessionModel CreateSession(string username, string password)
        {
            var user = _identityProvider.Get(username);

            if (user == null)
                throw new ApplicationException("User not found");

            var sessionId = Guid.NewGuid();

            var claims = _claimsFactory.Create(sessionId, user);

            var token = _tokenFactory.Create(claims);

            var session = new SessionModel
            {
                SessionId = sessionId,
                UserInfo = user,
                AccessToken = token
            };

            return session;
        }
    }
}
