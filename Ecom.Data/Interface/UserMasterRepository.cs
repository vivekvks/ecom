using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Interface
{
    public interface IUserMasterRepository
    {
        UserRegistrationResponse UserRegistration(UserRegistrationRequest request);
    }
}
