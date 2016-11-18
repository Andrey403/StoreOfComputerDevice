using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreOfComputerDevice
{
    public class DevicesWebcameraEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AmountMpx { get; set; }
        public int LengthOfCoord { get; set; }
        public bool InBuiltMicrophone { get; set; }
        public decimal Price { get; set; }
    }
}