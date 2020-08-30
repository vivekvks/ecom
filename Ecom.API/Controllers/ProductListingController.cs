using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListingController : ControllerBase
    {
        private readonly IProductListingService _productListingService;
        public ProductListingController(IProductListingService productListingService)
        {
            _productListingService = productListingService;
        }
        // POST api/<ProductListingController>
        [HttpPost]
        public IActionResult Post([FromBody] List<ProductListingRequest> requests)
        {
            var response = _productListingService.AddRange(requests);
            return Ok(response);
        }
    }
}
