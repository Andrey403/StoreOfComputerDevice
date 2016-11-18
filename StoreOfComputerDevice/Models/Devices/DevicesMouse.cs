using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreOfComputerDevice
{
    public class DevicesMouse
    {
        public int mouseId { get; set; }
        public string Name { get; set; }
        public int AmountButtons { get; set; }
        public int LengthOfCoord { get; set; }
        public int Dpi { get; set; }
        public string TypeOfMouse { get; set; }
        public decimal Price { get; set; }
    }
}