using App.Services.Common.Interfaces.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrustructure.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtSettings _jwtToken;

        public JwtTokenGenerator(IOptions<JwtSettings> options)
        {
            _jwtToken = options.Value;
        }

        public string GenerateToken(Guid userId, string firstName, string lastName)
        {
            var siginingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtToken.Secret)),
                SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userId.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName,firstName),
                new Claim(JwtRegisteredClaimNames.FamilyName,lastName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };
            var securityToken = new JwtSecurityToken(
                issuer:_jwtToken.Issuer,
                audience:_jwtToken.Audience,
                expires: DateTime.Now.AddHours(_jwtToken.ExpiryMinutes),
                claims: claims,
                signingCredentials: siginingCredentials);
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
            throw new NotImplementedException();
        }
    }
}
