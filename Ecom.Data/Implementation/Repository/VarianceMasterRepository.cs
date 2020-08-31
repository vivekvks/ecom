using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Response.VarianceMaster;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class VarianceMasterRepository : IVarianceMasterRepository
    {
        private readonly IRepository _repository;
        public VarianceMasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public List<VarianceMasterGetResponse> List()
        {
            return _repository.ExecResult<VarianceMasterGetResponse>(StoredProcedure.VARIANCEMASTER_LIST, null).ToList();
        }
    }
}
