using BancoPabloV.CLASES;
using BancoPabloV.SERVICIOS;
using System;
using static BancoPabloV.CLASES.Constants;

namespace BancoPabloV
{
    class Program
    {
        static void Main(string[] args)
        {

            UserService userService = new UserService();
            BankAccountService bankAccountService = new BankAccountService();
            EmployeeService employeeService = new EmployeeService();

            var pablo = userService.Register("Pablo", "pabloviturrod@gmail.com", Usertype.client);
            var adrian = userService.Register("Adrian", "adrian@email.com", Usertype.client);
            var empleadoChema = userService.Register("Chema", "chema@banco.com", Usertype.employee);

            pablo.bankAccount.AddBalance(1000);
            bankAccountService.Transaction(pablo.bankAccount, adrian.bankAccount, 200);


            employeeService.InterestRateCharge(pablo);
            employeeService.InterestRateCharge(adrian);
        }
    }
}
