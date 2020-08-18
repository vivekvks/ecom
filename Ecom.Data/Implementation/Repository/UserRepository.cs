using Ecom.Data.Models;

namespace Ecom.Data.Implementation.Repository
{
    public class UserRepository : GenericRepository<Users>
    {
        public UserRepository() : base("Users")
        {
        }
    }
}
