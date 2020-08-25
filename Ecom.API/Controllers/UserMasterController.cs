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
    public class UserMasterController : ControllerBase
    {
        private readonly IUserMasterService _userMasterService;
        public UserMasterController(IUserMasterService userMasterService)
        {
            _userMasterService = userMasterService;
        }

        [Route("Registration")]
        [HttpPost]
        public IActionResult Post([FromBody] UserRegistrationRequest request)
        {
            var response = _userMasterService.UserRegistration(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.REGISTER_SUCCESS, "User"), response));
        }

        [Route("{id:int}")]
        [HttpGet]
        public IActionResult Get([FromRoute] int id)
        {
            var response = _userMasterService.UserGet(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "User"), response));
        }
    }
}
