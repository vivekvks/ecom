using AutoWrapper.Wrappers;
using Ecom.Authentication;
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
    public class CompanyMasterController : ControllerBase
    {
        private readonly ICompanyMasterService _companyMasterService;
        private readonly IJwtReader _jwtReader;
        public CompanyMasterController(ICompanyMasterService companyMasterService, IJwtReader jwtReader)
        {
            _companyMasterService = companyMasterService;
            _jwtReader = jwtReader;
        }

        [Route("Registration")]
        [HttpPost]
        [Authorize(Policy = Policies.Admin)]
        public IActionResult Post([FromBody] CompanyRegistrationRequest request)
        {
            request.UserId = _jwtReader.UserId;
            var response = _companyMasterService.CompanyRegistration(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.REGISTER_SUCCESS, "Company"), response));
        }

        [Route("{id:int}")]
        [HttpGet]
        [Authorize(Policy = Policies.Admin)]
        public IActionResult Get([FromRoute] int id)
        {
            var response = _companyMasterService.CompanyGet(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "Company"), response));
        }
    }
}
