using Ecom.Authentication;
using Ecom.Data;
using Ecom.Models.Web;
using Ecom.Models.Web.Response;
using Ecom.Service.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service
{
    public class UserService : IUserService   
    {
        private readonly UserRepository _userRepository;
        private readonly IConfiguration _config;

        public UserService(IConfiguration config)
        {
            _userRepository = new UserRepository();
            config = _config;       
        }
        public bool Login(string email, string password)
        {
            var data = _userRepository.GetUserByEmail(email);

            if (data != null)
            {
                if (data.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public Response<LoginResponse> Register(UserVM user)
        {

            var userObj = new Data.Models.Users();

            if (user.IsEmail)
            {
                userObj = _userRepository.AddUser(new Data.Models.Users
                {
                    Email = user.UserName,
                    Password = user.Password,
                });

            }
            else
            {
                userObj = _userRepository.AddUser(new Data.Models.Users
                {
                    PhoneNo = user.UserName,
                    Password = user.Password,
                });


            }

            return new Response<LoginResponse>()
            {
                Data = new LoginResponse
                {
                    Name = "",
                    Token = new JWT().GenerateJWTToken(new UserVM
                    {
                        IsEmail = false,
                        UserName = user.UserName
                    }, _config)
                }
            };
        }

        bool IUserService.Register(UserVM user)
        {
            throw new NotImplementedException();
        }
    }
}
