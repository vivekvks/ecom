using System.Linq;
using Ecom.Models.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ecom.Authentication;
using Microsoft.Extensions.Configuration;
using Ecom.Utility;
using Ecom.Service.Interface;
using Ecom.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IConfiguration _config;
        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public async System.Threading.Tasks.Task<string> Register([FromForm] UserVM user)
        {
            return "";

        }

    }
}
