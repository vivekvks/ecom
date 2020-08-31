using Ecom.Models.Request;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface IProductListingRepository
    {
        string Get(string listingText);
        List<int> AddRange(List<ProductListingRequest> requests);
    }
}
