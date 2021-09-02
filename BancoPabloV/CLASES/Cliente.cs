using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    class Client
    {
        public string Name { get; set; }
        private string Email { get; set; }
        public BankAccount bankAccount { get; set; }
     
        public Client(string name, string email)
        {
            Name = name;
            Email = email;
            bankAccount = new BankAccount(name);
        }

    }
}
