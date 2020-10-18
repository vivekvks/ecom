using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryVarianceDetailsRepository : ICategoryVarianceDetailsRepository
    {
        private readonly IRepository _repository;
        public CategoryVarianceDetailsRepository(IRepository repository)
        {
            _repository = repository;
        }

        public List<int> AddRange(List<CategoryVarianceDetailsAddRequest> requests)
        {
            var parameters = _repository.GetJsonParameter(requests);
            return _repository.ExecResult<int>(StoredProcedure.CATEGORYVARIANCEDETAILS_ADDRANGE, parameters).ToList();
        }

        public List<CategoryVarianceDetailsGetResponse> Get(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("id", id);
            return _repository.ExecResult<CategoryVarianceDetailsGetResponse>(StoredProcedure.CATEGORYVARIANCEDETAILS_GET, parameters).ToList();
        }
    }
}
