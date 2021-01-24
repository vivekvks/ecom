using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryVarianceDetailsController : ControllerBase
    {
        private readonly ICategoryVarianceDetailsService _categoryVarianceDetailsService;
        public CategoryVarianceDetailsController(ICategoryVarianceDetailsService categoryVarianceDetailsService)
        {
            _categoryVarianceDetailsService = categoryVarianceDetailsService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<CategoryVarianceDetailsAddRequest> requests)
        {
            var response = _categoryVarianceDetailsService.AddRange(requests);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "CategoryVarianceDetails"), response));
        }


        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            var response = _categoryVarianceDetailsService.Get(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "CategoryVarianceDetails"), response));
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var response = _categoryVarianceDetailsService.Delete(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.DELETE_SUCCESS, "CategoryVarianceDetails"), response));
        }
    }
}
