using Ecom.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Implementation.DBRepo
{
    public class UserRepo
    {

        public GenericRepository<Users> userRepo;

        public UserRepo()
        {
            userRepo = new GenericRepository<Users>("User");
        }

        public void GetALL()
        {
            var sadas = userRepo.GetAllAsync();
        }

    }
}
