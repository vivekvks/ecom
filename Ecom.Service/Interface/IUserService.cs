using Ecom.Models.Response;
using Ecom.Models.Web;

namespace Ecom.Service.Interface
{
    public interface IUserService
    {
        public bool Login(string email, string password);
        public System.Threading.Tasks.Task<Response<LoginResponse>> RegisterAsync(UserVM user);
    }
}
