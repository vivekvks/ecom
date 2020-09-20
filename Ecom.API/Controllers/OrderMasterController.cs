using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderMasterController : ControllerBase
    {
        private readonly IOrderMasterService _orderMasterService;
        public OrderMasterController(IOrderMasterService orderMasterService)
        {
            _orderMasterService = orderMasterService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] OrderMasterAddRequest request)
        {
            var response = _orderMasterService.Add(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "OrderMaster"), response));
        }
    }
}
