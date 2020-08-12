using Ecom.Models.Web;
using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface IUserService
    {
        public bool Login(string email, string password);
        public System.Threading.Tasks.Task<Response<LoginResponse>> RegisterAsync(UserVM user);
    }
}
