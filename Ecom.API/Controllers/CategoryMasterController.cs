using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

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
        [HttpGet("{id}/hierarchies")]
        public IActionResult GetHierarchyJson(int id, bool isRoot)
        {
            var categoryHierarchy = _categoryMasterService.GetHierarchyJson(id, isRoot);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "CategoryMaster"), categoryHierarchy));
        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoryMasterAddRequest request)
        {
            var categoryMasterId = _categoryMasterService.Add(request);
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
