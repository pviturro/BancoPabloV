using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    class Employee : Client
    {
        public string Name { get; set; }
        private string Email { get; set; }
        private BankAccount bankAccount { get; set; }

        public Employee(string name, string email) : base(name, email)
        {
            bankAccount = null;
        }
    }
}
