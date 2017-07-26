using SVC.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVC.Lib.Services
{
    public interface IGeofenceSvc
    {
        Task<bool> IsLocatedInGeofence(Location location);
    }
}
