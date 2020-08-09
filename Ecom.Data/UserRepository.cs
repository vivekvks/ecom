using Ecom.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ecom.Data
{
    public class UserRepository
    {
        private ECOMContext _context;
        public UserRepository()
        {
            _context = new ECOMContext();
        }

        public Users GetUserByPhone(string phoneNo)
        {
            var user = _context.Users.Where(x => x.PhoneNo.Equals(phoneNo)).SingleOrDefault();
            return user;
        }

        public Users GetUserByEmail(string email)
        {
            var user = _context.Users.Where(x => x.Email.Equals(email)).SingleOrDefault();
            return user;
        }

        public Users AddUser(Users user)
        {
            user.IsActive = true;
            user.FirstName = "";
            user.LastName = "";
            return _context.Users.Add(user).Entity;
        }
    }
}
