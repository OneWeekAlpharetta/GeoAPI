using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVC.WebAPI.Models;
using Microsoft.Extensions.Options;

namespace SVC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IOptions<AppSettings> _settings;

        public ValuesController(IOptions<AppSettings> settings)
        {
            _settings = settings;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _settings.Value.AzureSQLDBConn;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
