using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class ProductListingRepository : IProductListingRepository
    {
        private readonly IRepository _repository;
        public ProductListingRepository(IRepository repository)
        {
            _repository = repository;
        }

        public List<int> AddRange(List<ProductListingRequest> requests)
        {
            var parameters = _repository.GetJsonParameter(requests);
            return _repository.ExecResult<int>(StoredProcedure.PRODUCTLISTING_ADDRANGE, parameters).ToList();
        }
    }
}
