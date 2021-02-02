using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

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
        public List<int> AddRange(List<ProductListingAddRequest> requests, int userId)
        {
            return _productListingRepository.AddRange(requests, userId);
        }

        public void Update(ProductListingUpdateRequest request)
        {
            _productListingRepository.Update(request);
        }

        public List<ProductListingResponse> List(int pageSize, int pageNumber, int userId)
        {
            return _productListingRepository.List(pageSize, pageNumber, userId);
        }

        public List<ProductListingLookupResponse> Lookup(string searchText)
        {
            return _productListingRepository.Lookup(searchText);
        }

        public ProductListingFacetSearchResponse Search(int pageNumber, int pageSize, string searchText, int? categoryId, string filter, bool includeFacet)
        {
            if (!string.IsNullOrWhiteSpace(filter))
            {
                List<FacetFilter> filters;
                try
                {
                    filters = JsonConvert.DeserializeObject<List<FacetFilter>>(filter);
                }
                catch
                {
                    throw new Exception("Invalid Filter Value");
                }

                if (filters.Any(x => x.Value == null || x.Value.Count() == 0))
                    throw new Exception("Master Value 'v' is required");
            }
            else
                filter = null;

            var dataSets = _productListingRepository.Search(pageSize, pageNumber, searchText, categoryId, filter, includeFacet);

            return new ProductListingFacetSearchResponse()
            {
                Data = dataSets.Item1,
                Facet = dataSets.Item2,
                TotalCount = dataSets.Item1.FirstOrDefault()?.TotalCount ?? 0
            };
        }

        public string GetProductDetail(int? id, int categoryId)
        {
            return _productListingRepository.GetProductDetail(id, categoryId);
        }
    }
}
