using Ecom.Models.Response;
using Ecom.Models.Web;
using Ecom.Service.Interface;
using System;
using System.Threading.Tasks;

namespace Ecom.Service
{
    public class UserService : IUserService
    {

        public bool Login(string email, string password)
        {
            return false;

        }

        public Task<Response<LoginResponse>> RegisterAsync(UserVM user)
        {
            throw new NotImplementedException();
        }
    }
}
