using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entities
{

        public class KeyboardEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int AmountKeys { get; set; }
            public string Color { get; set; }
            public string Type { get; set; }
            public string TypeOfConnector { get; set; }
            public int LengthOfCoord { get; set; }
            public decimal Price { get; set; }
        }

       

}
