using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Authentication;
using Ecom.Service.Interface;
using Ecom.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecom.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ConfigurationOption _configuration;
        private readonly ICategoryMasterService _categoryMasterService;
        public CategoryController(IOptions<ConfigurationOption> options,
            ICategoryMasterService categoryMasterService)
        {
            _configuration = options.Value;
            _categoryMasterService = categoryMasterService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<string> Get()
        {
            var category = await _categoryMasterService.Get();
            return category;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        [HttpPost]

        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>

        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
