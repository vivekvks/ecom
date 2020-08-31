using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
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
    }
}
