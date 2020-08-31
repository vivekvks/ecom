using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductListingController : ControllerBase
    {
        private readonly IProductListingService _productListingService;
        public ProductListingController(IProductListingService productListingService)
        {
            _productListingService = productListingService;
        }
        
        [HttpGet]
        [Route("detail")]
        public IActionResult GetProduct([FromQuery]string listingText)
        {
            var response = _productListingService.Get(listingText);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "ProductListing"), response));
        }
        [HttpPost]
        public IActionResult Post([FromBody] List<ProductListingRequest> requests)
        {
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(requests);
            var response = _productListingService.AddRange(requests);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "ProductListing"), response));
        }
    }
}
