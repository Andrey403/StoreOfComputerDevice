using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StoreOfComputerDevice.Devices
{
    public class MouseDBContext : DbContext
    {
        public DbSet<DevicesMouse> DevicesMouse { get; set; }
    }
}