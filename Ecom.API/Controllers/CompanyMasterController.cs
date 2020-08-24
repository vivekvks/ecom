using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Web.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyMasterController : ControllerBase
    {
        private readonly ICompanyMasterService _CompanyMasterService;
        public CompanyMasterController(ICompanyMasterService CompanyMasterService)
        {
            _CompanyMasterService = CompanyMasterService;
        }

        [Route("Registration")]
        [HttpPost]
        public IActionResult Post([FromBody] CompanyRegistrationRequest request)
        {
            var response = _CompanyMasterService.CompanyRegistration(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.REGISTER_SUCCESS, "Company"), response));
        }

    }
}
