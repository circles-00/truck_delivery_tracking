using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Truck_Delivery_Tracking.Models
{
    public class Driver : IdentityUser
    {
        public virtual DriverInfo DriverInfo { get; set; }
    }

    public class DriverInfo
    {
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string pictureURL { get; set; }
    }
    public class DriverDbContext : IdentityDbContext<Driver>
    {
        public DriverDbContext()
            : base("DefaultConnection")
        {
        }
        public System.Data.Entity.DbSet<DriverInfo> Driver { get; set; }
    }
}