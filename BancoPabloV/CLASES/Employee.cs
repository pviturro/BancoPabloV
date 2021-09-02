using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    class Employee : Client
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private BankAccount bankAccount { get; set; }

        public Employee(string name, string email)
        {
            Name = name;
            Email = email;
            bankAccount = new BankAccount(name);
        }
    }
}
