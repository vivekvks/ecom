using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        // GET: api/<CategoryMasterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CategoryMasterController>/5
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

        // PUT api/<CategoryMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
