﻿using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Linq;

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

        public UserGetResponse UserGet(int userId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", userId);
            return _repository.ExecResult<UserGetResponse>(StoredProcedure.USER_GET, parameters).FirstOrDefault();
        }
    }
}
