using CustomAuth.Auth.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace CustomAuth.Services
{
    public class TokenValidator : ITokenValidator
    {
        private readonly CustomAuthSchemeOptions _authSchemeOptions;

        public TokenValidator(IOptions<CustomAuthSchemeOptions> authSchemeOptions)
        {
            _authSchemeOptions = authSchemeOptions.Value;
        }

        public bool IsValid(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_authSchemeOptions.Secret));
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = _authSchemeOptions.Issuer,
                    ValidAudience = _authSchemeOptions.Audience,
                    IssuerSigningKey = securityKey
                }, out var validatedToken);
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }
    }
}
