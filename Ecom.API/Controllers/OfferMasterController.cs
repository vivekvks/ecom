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
    public class OfferMasterController : ControllerBase
    {
        private readonly IOfferMasterService _offerMasterService;
        public OfferMasterController(IOfferMasterService offerMasterService)
        {
            _offerMasterService = offerMasterService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var response = _offerMasterService.List();
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "OfferMaster"), response));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = _offerMasterService.Get(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "OfferMaster"), response));
        }

        [HttpPost]
        public IActionResult Post([FromBody] OfferMasterAddRequest request)
        {
            var response = _offerMasterService.Add(request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.ADD_SUCCESS, "OfferMaster"), response));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] OfferMasterUpdateRequest request)
        {
            var response = _offerMasterService.Update(id, request);
            return Ok(new ApiResponse(string.Format(ResponseMessage.UPDATE_SUCCESS, "OfferMaster"), response));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var response = _offerMasterService.Delete(id);
            return Ok(new ApiResponse(string.Format(ResponseMessage.DELETE_SUCCESS, "OfferMaster"), response));
        }
    }
}
