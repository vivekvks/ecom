using Ecom.Models.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ecom.Authentication
{
    public class JWTHelper
    {
        public string GenerateJWTToken(TokenData tokenData, IConfiguration _config)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            expires: DateTime.Now.AddMinutes(int.Parse(_config["Jwt:Expiry"])),
            signingCredentials: credentials
            );

            token.Payload.Add("data", tokenData);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}