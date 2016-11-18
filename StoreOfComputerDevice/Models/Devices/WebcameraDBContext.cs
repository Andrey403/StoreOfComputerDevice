using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StoreOfComputerDevice.Devices
{
    public class WebcameraDBContext : DbContext
    {
        public DbSet<DevicesWebcameraEntity> DevicesWebcamera { get; set; }
    }
}