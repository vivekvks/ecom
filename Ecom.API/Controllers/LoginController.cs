using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Models.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ecom.Authentication;
using Microsoft.Extensions.Configuration;

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
        public string Register([FromForm] UserVM user)
        {
            if (ModelState.IsValid)
            {
                JWT j = new JWT();
                return j.GenerateJWTToken(user, _config);
            }
            else
            {
                var modal = ModelState.Values.SelectMany(v => v.Errors).Select(x => new
                {
                    Error = x.ErrorMessage
                });
                return "false";
            }

        }


    }
}
