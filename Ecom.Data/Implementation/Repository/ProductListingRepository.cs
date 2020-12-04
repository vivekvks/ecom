using Dapper;
using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<int> AddRange(List<ProductListingAddRequest> requests)
        {
            var parameters = _repository.GetJsonParameter(requests);
            return _repository.ExecResult<int>(StoredProcedure.PRODUCTLISTING_ADDRANGE, parameters).ToList();
        }

        public void Update(ProductListingUpdateRequest request)
        {
            var parameters = _repository.GetParameters(request);
            _repository.ExecResult<int>(StoredProcedure.PRODUCTLISTING_UPDATE, parameters).ToList();
        }

        public List<ProductListingResponse> List(int pageSize, int pageNumber, int userId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("PageSize", pageSize);
            parameters.Add("PageNumber", pageNumber);
            parameters.Add("UserId", userId);
            return _repository.ExecResult<ProductListingResponse>(StoredProcedure.PRODUCTLISTING_GETBYUSERID, parameters);
        }

        public List<ProductListingLookupResponse> Lookup(string searchText)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("SearchText", searchText);
            return _repository.ExecResult<ProductListingLookupResponse>(StoredProcedure.PRODUCTLISTING_LOOKUP, parameters);
        }

        public Tuple<List<ProductListingFacetSearch>, List<ProductListingFacet>> Search(int pageSize, int pageNumber, string searchText, int? categoryId, string filter, bool includeFacet)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("SearchText", searchText);
            parameters.Add("CategoryId", categoryId);
            parameters.Add("IncludeFacet", includeFacet);
            parameters.Add("PageSize", pageSize);
            parameters.Add("PageNumber", pageNumber);
            parameters.Add("VarianceFilter", filter);
            return _repository.ExecResult<ProductListingFacetSearch, ProductListingFacet>(StoredProcedure.PRODUCTLISTING_FACETSEARCH, parameters);
        }

        public string GetProductDetail(int? id, int categoryId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id", id);
            parameters.Add("categoryId", categoryId);
            return _repository.ExecResult<BaseResult>(StoredProcedure.PRODUCTLISTING_DETAIL_GET, parameters).FirstOrDefault().JsonData;
        }
    }
}
