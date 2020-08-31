using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper.Wrappers;
using Ecom.Authentication;
using Ecom.Models.Constants;
using Ecom.Models.Enums;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerMasterController : ControllerBase
    {
        private readonly IJwtReader _jwtReader;
        private readonly IAnswerMasterService _answerMasterService;
        public AnswerMasterController(IJwtReader jwtReader, IAnswerMasterService AnswerMasterService)
        {
            _jwtReader = jwtReader;
            _answerMasterService = AnswerMasterService;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            var response = _answerMasterService.Get(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "AnswerMaster"), response));
        }

        [HttpPost]
        public IActionResult Post([FromBody] AnswerMasterAddRequest request)
        {
            request.UserId = _jwtReader.UserId;
            var response = _answerMasterService.Add(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "AnswerMaster"), response));
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] AnswerMasterUpdateRequest request)
        {
            request.Id = id;
            request.UserId = _jwtReader.UserId;
            var response = _answerMasterService.Update(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "AnswerMaster"), response));
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _answerMasterService.Delete(id, _jwtReader.UserId);
            return Ok(new ApiResponse(string.Format(ResponseMessage.DELETE_SUCCESS, "AnswerMaster")));
        }

        [HttpPut("{id:int}/reaction")]
        public IActionResult SaveReaction([FromRoute] int id, [FromBody] AnswerReactionRequest request)
        {
            request.UserId = _jwtReader.UserId;
            request.Id = id;
            _answerMasterService.SaveReaction(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "Answer reaction")));
        }
    }
}
