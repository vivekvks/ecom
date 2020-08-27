using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
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
            var response = _userMasterService.Registration(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.REGISTER_SUCCESS, "User"), response));
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
