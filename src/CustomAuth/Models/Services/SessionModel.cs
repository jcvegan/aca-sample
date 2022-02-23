using CustomAuth.Models.Providers;

namespace CustomAuth.Models.Services
{
    public class SessionModel
    {
        public Guid SessionId { get; set; } = Guid.NewGuid();
        public string AccessToken { get; set; } = string.Empty;
        public IdentityUser UserInfo { get; set; } = new IdentityUser();
    }
}
