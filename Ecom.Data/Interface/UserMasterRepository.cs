using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Data.Interface
{
    public interface IUserMasterRepository
    {
        UserRegistrationResponse UserRegistration(UserRegistrationRequest request);

        UserGetResponse UserGet(int userId);
    }
}
