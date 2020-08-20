using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<ActionResult<GetCategoryMasterResponse>> GetById(int id)
        {
            var categoryOrder = await _categoryMasterService.Get(id);
            return Ok(categoryOrder);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddCategoryMasterRequest request)
        {
            var response = await _categoryMasterService.Create(request);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] AddCategoryMasterRequest request)
        {
            var response = await _categoryMasterService.Update(id, request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryMasterService.Delete(id);
            return NoContent();
        }
    }
}
