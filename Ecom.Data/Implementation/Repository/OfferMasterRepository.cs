using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class OfferMasterRepository : IOfferMasterRepository
    {
        private readonly IRepository _repository;
        public OfferMasterRepository(IRepository repository)
        {
            _repository = repository;
        }

        public List<OfferMasterGetResponse> List()
        {
            return _repository.ExecResult<OfferMasterGetResponse>(StoredProcedure.OFFERMASTER_LIST, null).ToList();
        }

        public OfferMasterGetResponse Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            return _repository.ExecResult<OfferMasterGetResponse>(StoredProcedure.OFFERMASTER_GET, parameters).FirstOrDefault();
        }
        public int Add(OfferMasterAddRequest request)
        {
            var parameters = _repository.GetParameters(request);
            return _repository.ExecResult<int>(StoredProcedure.OFFERMASTER_ADD, parameters).FirstOrDefault();
        }
        public int Update(int id, OfferMasterUpdateRequest request)
        {
            var parameters = _repository.GetParameters(request);
            parameters.Add("Id", id);
            return _repository.ExecResult<int>(StoredProcedure.OFFERMASTER_UPDATE, parameters).FirstOrDefault();
        }
        public bool Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            _repository.ExecResult<int>(StoredProcedure.OFFERMASTER_DELETE, parameters).FirstOrDefault();
            return true;
        }
    }
}
