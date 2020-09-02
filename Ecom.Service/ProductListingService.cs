using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;

namespace Ecom.Service
{
    public class ProductListingService : IProductListingService
    {

        private readonly IProductListingRepository _productListingRepository;
        public ProductListingService(IProductListingRepository productListingRepository)
        {
            _productListingRepository = productListingRepository;
        }

        public string Get(string listingText)
        {
            if (string.IsNullOrWhiteSpace(listingText))
                throw new Exception("The ListingText is required");

            return _productListingRepository.Get(listingText);
        }
        public List<int> AddRange(List<ProductListingAddRequest> requests)
        {
            return _productListingRepository.AddRange(requests);
        }
    }
}
