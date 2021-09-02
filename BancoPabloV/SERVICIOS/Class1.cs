using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class BankAccountService
    {
        public void Transaction(BankAccount sender, BankAccount receiver, decimal quantity)
        {
            string title = sender.Owner + " ha enviado " + quantity + "€ a " + receiver.Owner;
            string message = "La transacción no ha dado ningún error y todos felices!";
            Notification transactionNotif = new Notification(title, message);
            try
            {
                sender.BalanceReduction(quantity);
                receiver.BalanceRaise(quantity);
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            Console.WriteLine(transactionNotif.sendSms(title, message));
        }
    }
}
