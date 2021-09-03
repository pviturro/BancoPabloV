using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    abstract class User
    {
        public string Name { get; set; }
        private string Email { get; set; }
        public BankAccount bankAccount { get; set; }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
            this.bankAccount = new BankAccount(name);
        }

    }
}
