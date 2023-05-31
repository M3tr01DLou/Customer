using JWT;
using JWT.Algorithms;
using JWT.Exceptions;
using JWT.Serializers;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;

namespace Customer.WEB.Helpers
{
    public class TokenServices : ITokenServices
    {
        private readonly IConfiguration _configuration;

        public TokenServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string VerifySignatureAndRefresh(string token)
        {
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                UtcDateTimeProvider provider = new();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

                string json = decoder.Decode(token, Convert.FromBase64String(_configuration["EnvironmentVariables:API_SECURITY_KEY"]), verify: true);
                return token;
            }
            catch (TokenExpiredException)
            {
                return GenerateToken(token);
            }
            catch (SignatureVerificationException)
            {
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        private string GenerateToken(string token)
        {

            try
            {
                JwtSecurityTokenHandler tokenHandler = new();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);

                SecurityTokenDescriptor securityTokenDescriptor = new()
                {
                    Subject = new ClaimsIdentity(jwtToken.Claims),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Convert.FromBase64String(_configuration["EnvironmentVariables:API_SECURITY_KEY"])), SecurityAlgorithms.HmacSha256Signature)
                };

                SecurityToken tokenR = tokenHandler.CreateToken(securityTokenDescriptor);
                return tokenHandler.WriteToken(tokenR);

            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
