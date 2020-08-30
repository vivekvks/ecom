using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service
{
    public class ProductListingService : IProductListingService
    {

        private readonly IProductListingRepository _productListingRepository;
        public ProductListingService(IProductListingRepository productListingRepository)
        {
            _productListingRepository = productListingRepository;
        }
        public List<int> AddRange(List<ProductListingRequest> requests)
        {
            return _productListingRepository.AddRange(requests);
        }
    }
}
