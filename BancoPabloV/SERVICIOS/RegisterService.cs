using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class RegisterService
    {
        public Client Register(string name, string phoneNumber)
        {
            return new Client(name, phoneNumber);
        }

    }
}
