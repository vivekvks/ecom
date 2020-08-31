using Ecom.Utility;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ecom.Authentication
{
    public class JwtHelper : IJwtHelper
    {
        public string GenerateJWTToken(JwtTokenModel tokenData, Jwt jwt)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] { new Claim("role", tokenData.RoleId.Description()) };

            var token = new JwtSecurityToken
            (
                issuer: jwt.Issuer,
                audience: jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(jwt.Expiry),
                signingCredentials: credentials
            );

            token.Payload.Add("user", tokenData);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}