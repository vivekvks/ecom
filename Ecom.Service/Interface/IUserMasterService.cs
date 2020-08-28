using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Service.Interface
{
    public interface IUserMasterService
    {
        UserRegistrationResponse Registration(UserRegistrationRequest request);
        UserGetResponse Get(int userId);
        UserLoginResponse Login(UserLoginRequest request);
    }
}
