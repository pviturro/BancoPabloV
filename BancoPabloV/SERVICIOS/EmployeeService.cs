using BancoPabloV.CLASES;
using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class EmployeeService
    {
        public void InterestRateCharge(Employee employee, User client)
        {
            decimal interestRate = 0.02m;
            decimal result = client.bankAccount.Balance * interestRate;
            client.bankAccount.RemoveBalance(result);
            Console.WriteLine($"{employee.Name} ha cargado {result} a la cuenta de {client.Name} por concepto de tipo de interés");
        }

    }
}
