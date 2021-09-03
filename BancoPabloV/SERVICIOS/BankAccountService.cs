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
            string title = $"{sender.Owner} ha enviado {quantity}€ a {receiver.Owner}";
            string message = "Tranascción completada";
            Notification transactionNotif = new Notification(title, message);
            sender.BalanceReduction(quantity);
            receiver.BalanceRaise(quantity);
            Console.WriteLine(transactionNotif.sendNotification(title, message));
        }
    }
}
