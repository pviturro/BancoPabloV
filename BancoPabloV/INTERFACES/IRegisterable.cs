using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;
using static BancoPabloV.CLASES.Constants;

namespace BancoPabloV.INTERFACES
{
    interface IRegisterable
    {
        public User Register(string name, string email, Usertype usertype);
        public bool Validate(string email);
    }
}
