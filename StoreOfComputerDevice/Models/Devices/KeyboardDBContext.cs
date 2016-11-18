using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StoreOfComputerDevice.Models;

namespace StoreOfComputerDevice.Model.Devices
{
    public class KeyboardDBContext : DbContext
    {
        public DbSet<DevicesKeyboardEntity> DevicesKeyboard { get; set; }
    }
}
