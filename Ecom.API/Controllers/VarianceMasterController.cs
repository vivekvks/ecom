using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VarianceMasterController : ControllerBase
    {
        private readonly IVarianceMasterService _varianceMasterService;
        public VarianceMasterController(IVarianceMasterService varianceMasterService)
        {
            _varianceMasterService = varianceMasterService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _varianceMasterService.Get();
            return Ok(response);
        }
    }
}
