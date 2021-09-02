using BancoPabloV.CLASES;
using BancoPabloV.SERVICIOS;
using System;

namespace BancoPabloV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ClientService clientService = new ClientService();
            BankAccountService bankAccountService = new BankAccountService();

            var empleadoChema = new Employee("Chema", "chemita@banco.com");
            var pablo = clientService.Register("Pablo", "pabloviturrod@gmail.com");
            var adrian = clientService.Register("Adrian", "adrian@email.com");

            pablo.bankAccount.BalanceRaise(1000);
            bankAccountService.Transaction(pablo.bankAccount, adrian.bankAccount, 200);
            

        }
    }
}
