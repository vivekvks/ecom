using Ecom.Models.Enums;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace Ecom.Authentication
{
    public class JwtReader : IJwtReader
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private JwtTokenModel _jwtTokenModel;

        public JwtReader(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int UserId { get { return _jwtTokenModel.UserId;  } }

        public string Email { get { return _jwtTokenModel.Email; } }

        public string PhoneNo { get { return _jwtTokenModel.PhoneNo; } }

        public RoleType RoleId { get { return _jwtTokenModel.RoleId; } }

        public bool IsRegistrationCompleted { get { return _jwtTokenModel.IsRegistrationCompleted; } }

        public string FirstName { get { return _jwtTokenModel.FirstName; } }

        public string LastName { get { return _jwtTokenModel.LastName; } }

        private JwtTokenModel JwtTokenModel
        {
            get
            {
                if (_jwtTokenModel == null)
                {
                    ReadToken();
                }
                return _jwtTokenModel;
            }
        }

        private void ReadToken()
        {
            _jwtTokenModel = new JwtTokenModel();
            try
            {
                var accessToken = Convert.ToString(_httpContextAccessor.HttpContext.Request.Headers["Authorization"]);
                if (!string.IsNullOrWhiteSpace(accessToken))
                {
                    var tokenData = new JwtSecurityTokenHandler().ReadToken(accessToken.Split(" ")[1]) as JwtSecurityToken;
                    var userDataString = tokenData.Claims.FirstOrDefault(claims => claims.Type == "user").Value;
                    if (!string.IsNullOrWhiteSpace(userDataString))
                        _jwtTokenModel = JsonConvert.DeserializeObject<JwtTokenModel>(userDataString);
                }
            }
            catch { }
        }
    }
}
