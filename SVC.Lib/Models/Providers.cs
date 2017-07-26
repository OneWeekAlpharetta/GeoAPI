using System;
using System.Collections.Generic;

namespace SVC.Lib.Models
{
    public partial class Providers : IEntity
    {
        public int ProviderId { get; set; }
        public string Facility { get; set; }
        public string Line1StreetAddress { get; set; }
        public string Line2StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Url { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool? CloseToMarta { get; set; }
        public bool? InsuranceNeeded { get; set; }
        public int? Staff { get; set; }
    }
}
