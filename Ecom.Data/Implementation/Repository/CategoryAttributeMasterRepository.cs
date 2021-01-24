using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryAttributeMasterRepository : ICategoryAttributeMasterRepository
    {
        private readonly IRepository _repository;
        public CategoryAttributeMasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public List<int> AddRange(List<CategoryAttributeMasterAddRequest> requests)
        {
            var parameters = _repository.GetJsonParameter(requests);
            return _repository.ExecResult<int>(StoredProcedure.CATEGORYATTRIBUTEMASTER_ADDRANGE, parameters).ToList();
        }


        public List<CategoryAttributeMasterGetResponse> Get(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("id", id);
            return _repository.ExecResult<CategoryAttributeMasterGetResponse>(StoredProcedure.CATEGORYATTRIBUTEMASTER_GET, parameters).ToList();
        }

        public bool Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            _repository.ExecResult<int>(StoredProcedure.CATEGORYATTRIBUTEMASTER_DELETE, parameters);
            return true;
        }
    }
}
