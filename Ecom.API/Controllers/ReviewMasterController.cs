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
    public class ReviewMasterController : ControllerBase
    {
        private readonly IJwtReader _jwtReader;
        private readonly IReviewMasterService _reviewMasterService;
        public ReviewMasterController(IJwtReader jwtReader, IReviewMasterService reviewMasterService)
        {
            _jwtReader = jwtReader;
            _reviewMasterService = reviewMasterService;
        }

        [HttpGet("product/{id}")]
        public IActionResult List(int id)
        {
            var response = _reviewMasterService.List(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.LIST_SUCCESS, "ReviewMaster"), response));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ReviewMasterAddRequest request)
        {
            request.UserId = _jwtReader.UserId;
            var response = _reviewMasterService.Add(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "ReviewMaster"), response));
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] ReviewMasterUpdateRequest request)
        {
            request.Id = id;
            request.UserId = _jwtReader.UserId;
            _reviewMasterService.Update(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "ReviewMaster")));
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _reviewMasterService.Delete(id, _jwtReader.UserId);
            return Ok(new ApiResponse(string.Format(ResponseMessage.DELETE_SUCCESS, "ReviewMaster")));
        }

        [HttpPut("{id:int}/reaction")]
        public IActionResult SaveReaction([FromRoute] int id, [FromBody] ReviewReactionRequest request)
        {
            request.UserId = _jwtReader.UserId;
            request.Id = id;
            _reviewMasterService.SaveReaction(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "Review reaction")));
        }
    }
}
