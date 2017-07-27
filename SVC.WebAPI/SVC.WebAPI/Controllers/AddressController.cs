using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SVC.Lib.Models;
using SVC.Lib.Services;

namespace SVC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AddressController : Controller
    {
        private readonly IAddressSvc _addressSvc;

        public AddressController(IAddressSvc addressSvc)
        {
            _addressSvc = addressSvc;
        }

        // POST api/address
        [HttpPost]
        public JsonResult Post([FromBody]JObject value)
        {
            var data = JsonConvert.DeserializeObject<Location>(value.ToString());

            var location = _addressSvc.GetLatLong(data);

            return Json(location);
        }
    }
}