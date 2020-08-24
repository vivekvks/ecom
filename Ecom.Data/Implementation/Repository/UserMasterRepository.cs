using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using Ecom.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Implementation.Repository
{
    public class UserMasterRepository : IUserMasterRepository
    {
        private readonly IRepository _repository;
        public UserMasterRepository(IRepository repository)
        {
            _repository = repository;
        }

        public UserRegistrationResponse UserRegistration(UserRegistrationRequest request)
        {
            return _repository.ExecResult<UserRegistrationResponse>(StoredProcedure.USER_REGISTRATION, _repository.GetBaseParameters(request)).FirstOrDefault();
        }
    }
}
