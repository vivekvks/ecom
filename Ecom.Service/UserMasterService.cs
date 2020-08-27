using Ecom.Authentication;
using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using Ecom.Utility;
using Microsoft.Extensions.Options;
using System;

namespace Ecom.Service
{
    public class UserMasterService : IUserMasterService
    {
        private readonly IUserMasterRepository _userMasterRepository;
        private readonly IJWTHelper _jWTHelper;
        private ConfigurationOption _settings { get; set; }
        public UserMasterService(IUserMasterRepository userMasterRepository, IOptions<ConfigurationOption> settings, IJWTHelper jWTHelper)
        {
            _userMasterRepository = userMasterRepository;
            _settings = settings.Value;
            _jWTHelper = jWTHelper;
        }

        public UserRegistrationResponse Registration(UserRegistrationRequest request)
        {
            request.Password = StringHelper.Encrypt(request.Password, _settings.Settings.SaltKey);
            return _userMasterRepository.UserRegistration(request);
        }

        public UserGetResponse Get(int userId)
        {
            return _userMasterRepository.UserGet(userId);
        }

        public UserLoginResponse Login(UserLoginRequest request)
        {
            try
            {
                var result = _userMasterRepository.Login(request);
                if (request.Password != StringHelper.Decrypt(result.Password, _settings.Settings.SaltKey))
                    return null;

                TokenData tokenData = new TokenData()
                {
                    Email = result.Email,
                    PhoneNo = result.PhoneNo,
                    UserId = result.Id,
                    RoleTypeId = result.RoleId,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    IsRegistrationCompleted = result.IsRegistrationCompleted
                };

                UserLoginResponse loginResponse = new UserLoginResponse()
                {
                    Token = _jWTHelper.GenerateJWTToken(tokenData, _settings.Jwt),
                    Type = "bearer"
                };

                return loginResponse;
            }
            catch
            {
                return null;
            }
        }
    }
}
