using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;

namespace SVC.Lib.Models
{
    public partial class fy18oneweekContext : DbContext
    {
        public virtual DbSet<Childcareproviders> Childcareproviders { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        private string _conn = string.Empty;

        public fy18oneweekContext(string conn)
        {
            _conn = conn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Childcareproviders>(entity =>
            {
                entity.HasKey(e => e.ProviderNumber)
                    .HasName("PK_childcareproviders");

                entity.ToTable("childcareproviders", "childcare");

                entity.Property(e => e.ProviderNumber)
                    .HasColumnName("Provider_Number")
                    .HasMaxLength(16);

                entity.Property(e => e.AcceptsChildCareSubsidy).HasColumnName("Accepts_Child_Care_Subsidy");

                entity.Property(e => e.AccreditationStatus)
                    .HasColumnName("Accreditation_Status")
                    .HasMaxLength(16);

                entity.Property(e => e.Address).HasMaxLength(128);

                entity.Property(e => e.AdminFirstName)
                    .HasColumnName("Admin_First_Name")
                    .HasMaxLength(32);

                entity.Property(e => e.AdminLastName)
                    .HasColumnName("Admin_Last_Name")
                    .HasMaxLength(32);

                entity.Property(e => e.AgesOtherThanPreKServed).HasColumnName("Ages_Other_Than_Pre_K_Served");

                entity.Property(e => e.Apr).HasColumnName("APR");

                entity.Property(e => e.Aug).HasColumnName("AUG");

                entity.Property(e => e.AvailablePreKSlots)
                    .HasColumnName("Available_PreK_Slots")
                    .HasMaxLength(16);

                entity.Property(e => e.City).HasMaxLength(32);

                entity.Property(e => e.County).HasMaxLength(16);

                entity.Property(e => e.Dec).HasColumnName("DEC");

                entity.Property(e => e.Feb).HasColumnName("FEB");

                entity.Property(e => e.Fri).HasColumnName("FRI");

                entity.Property(e => e.FundedPreKSlots).HasColumnName("Funded_PreK_Slots");

                entity.Property(e => e.HasCacfp).HasColumnName("Has_Cacfp");

                entity.Property(e => e.HasDropInCare).HasColumnName("Has_Drop_In_Care");

                entity.Property(e => e.HasEveningCare).HasColumnName("Has_Evening_Care");

                entity.Property(e => e.HasSchoolAgeOnly).HasColumnName("Has_School_Age_Only");

                entity.Property(e => e.HasSchoolAgeSummerCare).HasColumnName("Has_School_Age_Summer_Care");

                entity.Property(e => e.HasSpecialNeedsCare).HasColumnName("Has_Special_Needs_Care");

                entity.Property(e => e.HasTransportToFromHome).HasColumnName("Has_Transport_ToFrom_Home");

                entity.Property(e => e.HasTransportToFromSchool).HasColumnName("Has_Transport_ToFrom_School");

                entity.Property(e => e.HoursClose)
                    .HasColumnName("Hours_Close")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoursOpen)
                    .HasColumnName("Hours_Open")
                    .HasColumnType("datetime");

                entity.Property(e => e.Infant0To12mos).HasColumnName("Infant_0_To_12mos");

                entity.Property(e => e.Jan).HasColumnName("JAN");

                entity.Property(e => e.Jul).HasColumnName("JUL");

                entity.Property(e => e.Jun).HasColumnName("JUN");

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Location).HasMaxLength(128);

                entity.Property(e => e.Long).HasColumnName("long");

                entity.Property(e => e.MailingAddress).HasMaxLength(128);

                entity.Property(e => e.MailingCity).HasMaxLength(32);

                entity.Property(e => e.MailingState).HasMaxLength(2);

                entity.Property(e => e.Mar).HasColumnName("MAR");

                entity.Property(e => e.May).HasColumnName("MAY");

                entity.Property(e => e.Mon).HasColumnName("MON");

                entity.Property(e => e.Nov).HasColumnName("NOV");

                entity.Property(e => e.Oct).HasColumnName("OCT");

                entity.Property(e => e.OperationDays)
                    .HasColumnName("Operation_Days")
                    .HasMaxLength(32);

                entity.Property(e => e.OperationMonths)
                    .HasColumnName("Operation_Months")
                    .HasMaxLength(48);

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.PreKServed).HasColumnName("Pre_K_Served");

                entity.Property(e => e.Preschool3yrsTo4yrs).HasColumnName("Preschool_3yrs_To_4yrs");

                entity.Property(e => e.ProgramType)
                    .HasColumnName("Program_Type")
                    .HasMaxLength(32);

                entity.Property(e => e.ProviderType)
                    .HasColumnName("Provider_Type")
                    .HasMaxLength(16);

                entity.Property(e => e.QrParticipant).HasColumnName("QR_Participant");

                entity.Property(e => e.QrRated).HasColumnName("QR_Rated");

                entity.Property(e => e.QrRating).HasColumnName("QR_Rating");

                entity.Property(e => e.Sat).HasColumnName("SAT");

                entity.Property(e => e.SchoolAge5yrsPlus).HasColumnName("School_Age_5yrs_Plus");

                entity.Property(e => e.Sep).HasColumnName("SEP");

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.Sun).HasColumnName("SUN");

                entity.Property(e => e.Thu).HasColumnName("THU");

                entity.Property(e => e.Toddler13mosTo2yrs).HasColumnName("Toddler_13mos_To_2yrs");

                entity.Property(e => e.Tue).HasColumnName("TUE");

                entity.Property(e => e.Wed).HasColumnName("WED");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.HasKey(e => e.ProviderId)
                    .HasName("PK_publichealth_providers");

                entity.ToTable("providers", "health");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.City).HasColumnType("varchar(100)");

                entity.Property(e => e.Facility).HasColumnType("varchar(100)");

                entity.Property(e => e.Line1StreetAddress)
                    .HasColumnName("Line 1 Street Address")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Line2StreetAddress)
                    .HasColumnName("Line 2 Street Address")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone Number")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("Zip Code")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}