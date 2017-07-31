using Microsoft.Extensions.Configuration;
using SVC.Lib.Models;
using SVC.Lib.Repos;
using SVC.Lib.Services;
using System;
using System.Linq;

namespace SVC.Data
{
    class Program
    {
        private static IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings_sec.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            var conn = Configuration.GetSection("ApplicationSettings")["AzureSQLDBConn"];

            ChildCareRepository childcare = new ChildCareRepository(conn);
            HealthRepository healthcare = new HealthRepository(conn);

            var address = new AddressSvc();

            foreach (var cProvider in childcare.List.ToList())
            {
                Location location = new Location
                {
                    Address1 = cProvider.Address,
                    City = cProvider.City,
                    State = cProvider.State,
                    Zip = cProvider.Zip
                };

                var addy = address.GetLatLong(location).Result;

                cProvider.Lat = addy.Latitude;
                cProvider.Long = addy.Longitude;

                childcare.Update(cProvider);
            }

            foreach (var hProvider in healthcare.List.ToList())
            {
                Location location = new Location
                {
                    Address1 = hProvider.Line1StreetAddress,
                    City = hProvider.City,
                    State = hProvider.State,
                    Zip = hProvider.ZipCode
                };

                var addy = address.GetLatLong(location).Result;

                hProvider.Latitude = addy.Latitude;
                hProvider.Longitude = addy.Longitude;

                healthcare.Update(hProvider);
            }

            Console.WriteLine("Updated both healthcare and childcare providers");
        }
    }
}
