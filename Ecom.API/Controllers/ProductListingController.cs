using AutoWrapper.Wrappers;
using Ecom.Authentication;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductListingController : ControllerBase
    {
        private readonly IProductListingService _productListingService;
        private readonly IJwtReader _jwtReader;
        public ProductListingController(IProductListingService productListingService, IJwtReader jwtReader)
        {
            _productListingService = productListingService;
            _jwtReader = jwtReader;
        }

        [HttpGet]
        [Route("detail")]
        public IActionResult GetProduct([FromQuery] string listingText)
        {
            var response = _productListingService.Get(listingText);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "ProductListing"), response));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductListingRequest request)
        {
            var response = _productListingService.AddRange(request.ProductListings);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "ProductListing"), response));
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] ProductListingUpdateRequest request)
        {
            request.Id = id;
            request.UserId = _jwtReader.UserId;
            _productListingService.Update(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "ProductListing")));
        }

        [HttpGet]
        public IActionResult ProductList([FromQuery] int? pageSize, [FromQuery] int? pageNumber)
        {
            var response = _productListingService.List(pageSize ?? 10, pageNumber ?? 1, _jwtReader.UserId);
            return Ok(new ApiResponse(string.Format(ResponseMessage.LIST_SUCCESS, "ProductListing"), new { data = response, totalCount = response.FirstOrDefault()?.TotalCount ?? 0 }));
        }
    }
}
