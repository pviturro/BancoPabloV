using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    class Client : IUserable
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private BankAccount bankAccount { get; set; }
     
        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

    }
}
