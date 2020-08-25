using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface IUserMasterService
    {
        UserRegistrationResponse UserRegistration(UserRegistrationRequest request);
        UserGetResponse UserGet(int userId);
    }
}
