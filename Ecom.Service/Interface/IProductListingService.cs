using Ecom.Models.Request;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface IProductListingService
    {
        string Get(string listingText);
        List<int> AddRange(List<ProductListingAddRequest> requests);
    }
}
