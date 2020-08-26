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
        public IActionResult Post([FromBody] List<CategoryAttributeMasterAddRequest> addRequests)
        {
            var response = _categoryAttributeMasterService.Create(addRequests);
            return Ok(response);
        }
    }
}
