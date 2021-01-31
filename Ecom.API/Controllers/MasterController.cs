using AutoWrapper.Wrappers;
using Ecom.Authentication;
using Ecom.Models.Constants;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService _masterService;
        public MasterController(IMasterService masterService)
        {
            _masterService = masterService;
        }

        [HttpGet("country")]
        public IActionResult CountryLookup()
        {
            var response = _masterService.CountryLookup();
            return Ok(new ApiResponse(string.Format(ResponseMessage.LIST_SUCCESS, "CountryMaster"), response));
        }

        [HttpGet("attribute-and-variance")]
        public IActionResult AttributeAndVarianceValueLookup()
        {
            var response = _masterService.AttributeAndVarianceLookup();
            return Ok(new ApiResponse(string.Format(ResponseMessage.LIST_SUCCESS, "Attribute and variance"), response));
        }

        [HttpGet("tax")]
        public IActionResult TaxLookup()
        {
            var response = _masterService.TaxLookup();
            return Ok(new ApiResponse(string.Format(ResponseMessage.LIST_SUCCESS, "CountryMaster"), response));
        }
    }
}
