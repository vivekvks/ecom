using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserMasterService _userMasterService;
        public AuthenticationController(IUserMasterService userMasterService)
        {
            _userMasterService = userMasterService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest model)
        {
            var response = _userMasterService.Login(model);

            if (!response)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(new ApiResponse(ResponseMessage.LOGIN_SUCEESS, response));
        }
    }
}
