using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SVC.Lib.Models;

namespace SVC.Lib.Services
{
    public interface IAddressSvc
    {
        Task<Location> GetLatLong(Location location);
    }
}
