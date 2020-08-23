using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models.Web.Request;
using Ecom.Service;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Post([FromBody] List<CategoryVarianceDetailsAddRequest> addRequests)
        {
            var response = _categoryVarianceDetailsService.Create(addRequests);
            return Ok(response);
        }
    }
}
