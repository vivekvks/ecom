using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models.Web.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMasterController : ControllerBase
    {
        [Route("registration")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserRegistrationRequest request)
        {
            //var response = await _categoryMasterService.Create(request);
            return Ok();
        }
    }
}
