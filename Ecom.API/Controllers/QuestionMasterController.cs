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
    public class QuestionMasterController : ControllerBase
    {
        private readonly IJwtReader _jwtReader;
        private readonly IQuestionMasterService _questionMasterService;
        public QuestionMasterController(IJwtReader jwtReader, IQuestionMasterService questionMasterService)
        {
            _jwtReader = jwtReader;
            _questionMasterService = questionMasterService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = _questionMasterService.Get(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "QuestionMaster"), response));
        }

        [HttpGet("product/{id}")]
        public IActionResult List(int id)
        {
            var response = _questionMasterService.List(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.LIST_SUCCESS, "QuestionMaster"), response));
        }

        [HttpPost]
        public IActionResult Post([FromBody] QuestionMasterAddRequest request)
        {
            request.UserId = _jwtReader.UserId;
            var response = _questionMasterService.Add(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "QuestionMaster"), response));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] QuestionMasterUpdateRequest request)
        {
            request.Id = id;
            request.UserId = _jwtReader.UserId;
            var response = _questionMasterService.Update(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "QuestionMaster"), response));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _questionMasterService.Delete(id, _jwtReader.UserId);
            return Ok(new ApiResponse(string.Format(ResponseMessage.DELETE_SUCCESS, "QuestionMaster")));
        }
    }
}
