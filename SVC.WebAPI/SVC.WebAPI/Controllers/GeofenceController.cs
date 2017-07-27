    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SVC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class GeofenceController : Controller
    {
        // POST api/geofence
        [HttpPost]
        public void Post()
        {
        }
    }
}