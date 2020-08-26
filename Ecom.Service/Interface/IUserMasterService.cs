using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Service.Interface
{
    public interface IUserMasterService
    {
        UserRegistrationResponse UserRegistration(UserRegistrationRequest request);
        UserGetResponse UserGet(int userId);
    }
}
