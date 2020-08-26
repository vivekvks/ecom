using System.Collections.Generic;
using System.Threading.Tasks;
using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryMasterController : ControllerBase
    {
        private readonly ICategoryMasterService _categoryMasterService;
        public CategoryMasterController(ICategoryMasterService categoryMasterService)
        {
            _categoryMasterService = categoryMasterService;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var categoryMaster = _categoryMasterService.Get(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "CategoryMaster"), categoryMaster));
        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoryMasterAddRequest request)
        {
            var categoryMasterId = _categoryMasterService.Create(request);
            var response = _categoryMasterService.Get(categoryMasterId);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "CategoryMaster"), response));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CategoryMasterUpdateRequest request)
        {
            var categoryMasterId = _categoryMasterService.Update(id, request);
            var response = _categoryMasterService.Get(categoryMasterId);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "CategoryMaster"), response));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _categoryMasterService.Delete(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.DELETE_SUCCESS, "CategoryMaster"), response));
        }
    }
}
