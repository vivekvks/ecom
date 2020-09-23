using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface IProductListingService
    {
        string Get(string listingText);
        List<int> AddRange(List<ProductListingAddRequest> requests);
        void Update(ProductListingUpdateRequest request);
        List<ProductListingResponse> List(int pageSize, int pageNumber, int userId);
        List<ProductListingLookupResponse> Lookup(string searchText);
        ProductListingFacetSearchResponse Search(int pageNumber, int pageSize, string searchText, int? categoryId, string filter, bool includeFacet);
    }
}
