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
    public class UserMasterController : ControllerBase
    {
        private readonly IUserMasterService _userMasterService;
        public UserMasterController(IUserMasterService userMasterService)
        {
            _userMasterService = userMasterService;
        }

        [Route("Registration")]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] UserRegistrationRequest request)
        {
            var response = _userMasterService.Registration(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.REGISTER_SUCCESS, "User"), response));
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login(UserLoginRequest model)
        {
            var response = _userMasterService.Login(model);

            if (response == null)
                return BadRequest(new { message = ResponseMessage.LOGIN_FAILED });

            return Ok(new ApiResponse(ResponseMessage.LOGIN_SUCEESS, response));
        }

        [Route("{id:int}")]
        [HttpGet]
        public IActionResult Get([FromRoute] int id)
        {
            var response = _userMasterService.Get(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "User"), response));
        }
    }
}
