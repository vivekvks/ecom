using Dapper;
using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Constants;
using Ecom.Models.Response;
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

        public string Get(string listingText)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ListingText", listingText);
            return _repository.ExecResult<BaseResult>(StoredProcedure.PRODUCTLISTING_GET, parameters).FirstOrDefault().JsonData;
        }
    }
}
