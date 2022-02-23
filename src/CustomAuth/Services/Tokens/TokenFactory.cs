using CustomAuth.Auth.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CustomAuth.Services
{
    public class TokenFactory : ITokenFactory
    {
        private readonly CustomAuthSchemeOptions _customAuthOptions;

        public TokenFactory(IOptions<CustomAuthSchemeOptions> customAuthOptions)
        {
            _customAuthOptions = customAuthOptions.Value;
        }

        public string Create(IEnumerable<Claim> claims)
        {
            var secret = _customAuthOptions.Secret;

            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret)); 
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = _customAuthOptions.Issuer,
                Audience = _customAuthOptions.Audience,
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
