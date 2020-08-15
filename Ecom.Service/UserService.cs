using Ecom.Authentication;
using Ecom.Data;
using Ecom.Data.Implementation;
using Ecom.Data.Implementation.DBRepo;
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
        private readonly Data.Implementation.DBRepo.UserRepository _userRepository;
        private readonly IConfiguration _config;

        private readonly GenericRepository<UserVM> genericRepository;

        public UserService(IConfiguration config)
        {
            _userRepository = new Data.Implementation.DBRepo.UserRepository();
          
            config = _config;
        }
        public bool Login(string email, string password)
        {
           // var data = _userRepository.GetUserByEmail(email);

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

        public async System.Threading.Tasks.Task<Response<LoginResponse>> RegisterAsync(UserVM user)
        {

            var data = await genericRepository.GetAllAsync();

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

            return new  Response<LoginResponse>()
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
    }
}
