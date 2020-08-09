using Ecom.Models.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface IUserService
    {
        public bool Login(string email, string password);
        public bool Register(UserVM user);
    }
}
