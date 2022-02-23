using Microsoft.AspNetCore.Authentication;

namespace CustomAuth.Auth.Options
{
    public class CustomAuthSchemeOptions : AuthenticationSchemeOptions
    {
        public string Secret { get; set; } = string.Empty;
        public string Audience { get; set; } = "myAudience";
        public string Issuer { get; set; } = "custom";
    }
}
