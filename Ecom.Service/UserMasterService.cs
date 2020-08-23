using Ecom.Data.Interface;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using Ecom.Service.Interface;
using Ecom.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

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

        public UserRegistrationResponse UserRegistration(UserRegistrationRequest request)
        {
            request.Password = StringHelper.Encrypt(request.Password, _settings.SaltKey);
            return _userMasterRepository.UserRegistration(request);
        }
    }
}
