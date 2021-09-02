using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    class Client : IUserable
    {
        public Client(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        private string Name { get; set; }
        private string PhoneNumber { get; set; }

    }
}
