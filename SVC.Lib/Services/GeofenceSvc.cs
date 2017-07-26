using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SVC.Lib.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace SVC.Lib.Services
{
    public class GeofenceSvc : IGeofenceSvc
    {
        public async Task<bool> IsLocatedInGeofence(Location location)
        {
            var url = $"https://spatial.virtualearth.net/REST/v1/data/53e1e9c5023440a9bd2b76a6637f4025/atlmapmarta/TestBoundaries?SpatialFilter=intersects('POINT%20({location.Longitude}%20{location.Latitude})')&$format=json&key=Ah8gBUJ4ZmkEUffX4cjv9-FZmciYRfoHb9TAnR-zyZzs6zu6pOPzbYNBaVsY8PDI";
            var client = new HttpClient();
            var stringTask = await client.GetStringAsync(url);

            dynamic d = JsonConvert.DeserializeObject(stringTask);

            if (d.d.results.Count == 0) return false; else return true;
        }
    }
}
