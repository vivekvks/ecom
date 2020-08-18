using Ecom.Authentication;
using Ecom.Data;
using Ecom.Data.Implementation;
using Ecom.Data.Implementation.Repository;
using Ecom.Models.Web;
using Ecom.Models.Web.Response;
using Ecom.Service.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
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
