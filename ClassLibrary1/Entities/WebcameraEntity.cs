using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{
    public class Webcamera
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AmountMpx { get; set; }
        public int LengthOfCoord { get; set; }
        public bool InBuiltMicrophone { get; set; }
        public decimal Price { get; set; }
    }
}
