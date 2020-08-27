using AutoWrapper.Wrappers;
using Ecom.Models.Constants;
using Ecom.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryReturnMasterController : ControllerBase
    {
        private readonly ICategoryReturnMasterService _categoryReturnMasterService;
        public CategoryReturnMasterController(ICategoryReturnMasterService categoryReturnMasterService)
        {
            _categoryReturnMasterService = categoryReturnMasterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response =  _categoryReturnMasterService.List();
            return Ok(new ApiResponse(string.Format(ResponseMessage.GET_SUCCESS, "CategoryReturnMaster"), response));
        }
    }
}
