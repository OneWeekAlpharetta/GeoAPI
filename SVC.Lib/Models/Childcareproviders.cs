using System;
using System.Collections.Generic;

namespace SVC.Lib.Models
{
    public partial class Childcareproviders : IEntity
    {
        public string ProviderNumber { get; set; }
        public string Location { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public double? MailingZip { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string Phone { get; set; }
        public double? LicenseCapacity { get; set; }
        public string OperationMonths { get; set; }
        public string OperationDays { get; set; }
        public DateTime? HoursOpen { get; set; }
        public DateTime? HoursClose { get; set; }
        public bool Infant0To12mos { get; set; }
        public bool Toddler13mosTo2yrs { get; set; }
        public bool Preschool3yrsTo4yrs { get; set; }
        public bool PreKServed { get; set; }
        public bool SchoolAge5yrsPlus { get; set; }
        public bool AgesOtherThanPreKServed { get; set; }
        public bool AcceptsChildCareSubsidy { get; set; }
        public bool HasEveningCare { get; set; }
        public bool HasDropInCare { get; set; }
        public bool HasSchoolAgeSummerCare { get; set; }
        public bool HasSpecialNeedsCare { get; set; }
        public bool HasTransportToFromSchool { get; set; }
        public bool HasSchoolAgeOnly { get; set; }
        public bool HasTransportToFromHome { get; set; }
        public bool HasCacfp { get; set; }
        public string AccreditationStatus { get; set; }
        public string ProgramType { get; set; }
        public string ProviderType { get; set; }
        public string AvailablePreKSlots { get; set; }
        public double? FundedPreKSlots { get; set; }
        public bool QrParticipant { get; set; }
        public bool QrRated { get; set; }
        public double? QrRating { get; set; }
        public bool? Jan { get; set; }
        public bool? Feb { get; set; }
        public bool? Mar { get; set; }
        public bool? Apr { get; set; }
        public bool? May { get; set; }
        public bool? Jun { get; set; }
        public bool? Jul { get; set; }
        public bool? Aug { get; set; }
        public bool? Sep { get; set; }
        public bool? Oct { get; set; }
        public bool? Nov { get; set; }
        public bool? Dec { get; set; }
        public bool? Sun { get; set; }
        public bool? Mon { get; set; }
        public bool? Tue { get; set; }
        public bool? Wed { get; set; }
        public bool? Thu { get; set; }
        public bool? Fri { get; set; }
        public bool? Sat { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public bool? CloseToMarta { get; set; }
    }
}
