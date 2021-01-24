using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryAttributeMasterController : ControllerBase
    {
        private readonly ICategoryAttributeMasterService _categoryAttributeMasterService;
        public CategoryAttributeMasterController(ICategoryAttributeMasterService categoryAttributeMasterService)
        {
            _categoryAttributeMasterService = categoryAttributeMasterService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<CategoryAttributeMasterAddRequest> requests)
        {
            var response = _categoryAttributeMasterService.AddRange(requests);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "CategoryAttributeMaster"), response));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            var response = _categoryAttributeMasterService.Get(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "CategoryAttributeMaster"), response));
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var response = _categoryAttributeMasterService.Delete(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.DELETE_SUCCESS, "CategoryAttributeMaster"), response));
        }
    }
}
