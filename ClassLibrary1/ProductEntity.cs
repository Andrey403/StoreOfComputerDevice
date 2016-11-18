using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProductEntity
    {
        public class Keyboard
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

        public class Mouse
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int AmountButtons { get; set; }
            public int LengthOfCoord { get; set; }
            public int Dpi { get; set; }
            public string TypeOfMouse { get; set; }
            public decimal Price { get; set; }
        }

        public class Webcamera
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int AmountMpx { get; set; }
            public int LengthOfCoord { get; set; }
            public bool InBuiltMicrophone { get; set; }
            public decimal Price { get; set; }
        }

        public class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Balance { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
        }

        public class Hamper
        {

        }
    }

}
