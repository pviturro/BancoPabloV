using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class EmployeeService
    {
        public void CreateAccount(Employee employee)
        {
            if (employee.bankAccount == null)
                employee.bankAccount = new BankAccount(employee.Name);
            else
                throw new Exception("Ya tienes una cuenta en el banco");
        }

        public void InterestRateCharge(Client client)
        {
            decimal interestRate = 0.02m;
            decimal result = client.bankAccount.Balance * interestRate;
            client.bankAccount.BalanceReduction(result);
            Console.WriteLine($"Se ha cargado {result}€ a la cuenta de {client.Name} por el tipo de interés");
        }

    }
}
