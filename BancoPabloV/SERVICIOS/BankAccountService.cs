using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class BankAccountService
    {
        private Notification transactionNotif;
        
        public void Transaction(BankAccount sender, BankAccount receiver, decimal quantity)
        {
            string title = $"{sender.Owner} ha enviado {quantity}€ a {receiver.Owner}";
            string message = "Tranascción completada";
            sender.RemoveBalance(quantity);
            receiver.AddBalance(quantity);
            transactionNotif = new Notification(title, message);
            Console.WriteLine(transactionNotif.sendNotification(title, message));
        }
    }
}
