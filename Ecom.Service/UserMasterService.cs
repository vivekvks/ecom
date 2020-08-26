using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using Ecom.Utility;
using Microsoft.Extensions.Options;

namespace Ecom.Service
{
    public class UserMasterService : IUserMasterService
    {
        private readonly IUserMasterRepository _userMasterRepository;
        private Settings _settings { get; set; }
        public UserMasterService(IUserMasterRepository userMasterRepository, IOptions<ConfigurationOption> settings)
        {
            _userMasterRepository = userMasterRepository;
            _settings = settings.Value.Settings;
        }

        public UserRegistrationResponse Registration(UserRegistrationRequest request)
        {
            request.Password = StringHelper.Encrypt(request.Password, _settings.SaltKey);
            return _userMasterRepository.UserRegistration(request);
        }

        public UserGetResponse Get(int userId)
        {
            return _userMasterRepository.UserGet(userId);
        }

        public bool Login(LoginRequest request)
        {
            var result = _userMasterRepository.Login(request);
            if (request.Password != StringHelper.Decrypt(result.Password, _settings.SaltKey))
                throw new System.Exception("Username or password is incorrect");
            //To Do Token Generation
            return true;
        }
    }
}
