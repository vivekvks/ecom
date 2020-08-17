using Ecom.Data.Models;

namespace Ecom.Data.Implementation.DBRepo
{
    public class UserRepository : GenericRepository<Users>
    {

        public GenericRepository<Users> userRepo;
        public UserRepository() : base("Users")
        {
        }
    }
}
