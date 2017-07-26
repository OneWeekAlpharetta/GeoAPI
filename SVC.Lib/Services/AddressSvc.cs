using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SVC.Lib.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace SVC.Lib.Services
{
    public class AddressSvc : IAddressSvc
    {
        public async Task<Location> GetLatLong(Location location)
        {
            var url = $"https://dev.virtualearth.net/REST/v1/Locations?countryRegion=US&adminDistrict={ location.State }&locality={ WebUtility.UrlEncode(location.City) }&postalCode={ location.Zip }&addressLine={ WebUtility.UrlEncode(location.Address1) }&key=Ah8gBUJ4ZmkEUffX4cjv9-FZmciYRfoHb9TAnR-zyZzs6zu6pOPzbYNBaVsY8PDI";
            var client = new HttpClient();
            var stringTask = await client.GetStringAsync(url);

            dynamic d = JsonConvert.DeserializeObject(stringTask);

            location.Latitude = d.resourceSets[0].resources[0].point.coordinates[0];
            location.Longitude = d.resourceSets[0].resources[0].point.coordinates[1];

            return location;
        }
    }
}
