using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Constants;
using Ecom.Models.Response;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryReturnMasterRepository : ICategoryReturnMasterRepository
    {
        private readonly IRepository _repository;
        public CategoryReturnMasterRepository(IRepository repository) 
        {
            _repository = repository;
        }

        public List<CategoryReturnMasterGetResponse> List()
        {
            return _repository.ExecResult<CategoryReturnMasterGetResponse>(StoredProcedure.CATEGORYRETURNMASTER_LIST, null).ToList();
        }
    }
}
