using Ecom.Models.Request;
using Ecom.Models.Response;
using System;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface IProductListingRepository
    {
        string Get(string listingText);
        List<int> AddRange(List<ProductListingAddRequest> requests, int userId);
        void Update(ProductListingUpdateRequest request);
        List<ProductListingResponse> List(int pageSize, int pageNumber, int userId);
        List<ProductListingLookupResponse> Lookup(string searchText);
        Tuple<List<ProductListingFacetSearch>, List<ProductListingFacet>> Search(int pageNumber, int pageSize, string searchText, int? categoryId, string filter, bool includeFacet);
        string GetProductDetail(int? id, int categoryId);
    }
}
