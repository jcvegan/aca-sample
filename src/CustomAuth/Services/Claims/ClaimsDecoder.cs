using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CustomAuth.Services
{
    public class ClaimsDecoder : IClaimsDecoder
    {
        public IEnumerable<Claim> Decode(string token)
        {
            var handler = new JwtSecurityTokenHandler();

            var jwtSecurityToken = handler.ReadJwtToken(token);

            var claims = jwtSecurityToken.Claims.Select(FormatToken);

            return claims;
        }

        private Claim FormatToken(Claim baseClaim)
        {
            switch (baseClaim.Type)
            {
                case "nameid":
                    return new Claim(ClaimTypes.NameIdentifier, baseClaim.Value);
                case "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid":
                    return new Claim(ClaimTypes.Sid, baseClaim.Value);
                case "given_name":
                    return new Claim(ClaimTypes.GivenName, baseClaim.Value);
                case "family_name":
                    return new Claim(ClaimTypes.GivenName, baseClaim.Value);
                case "role":
                    return new Claim(ClaimTypes.Role, baseClaim.Value);
                default:
                    return baseClaim;
            }
        }
    }
}
