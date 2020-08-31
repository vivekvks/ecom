using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VarianceMasterController : ControllerBase
    {
        private readonly IVarianceMasterService _varianceMasterService;
        public VarianceMasterController(IVarianceMasterService varianceMasterService)
        {
            _varianceMasterService = varianceMasterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _varianceMasterService.List();
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "VarianceMaster"), response));
        }
    }
}
