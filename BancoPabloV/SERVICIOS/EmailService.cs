using BancoPabloV.CLASES;
using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class EmailService : INotificable
    {
        public string sendNotification(User receiver, Notification notif)
        {
            return $"Para: {receiver.Email} {notif.Title}\n{notif.Message}";
        }

        public void sendEmail(User receiver, Notification notif)
        {
            Console.Write(sendNotification(receiver, notif));
        }

    }
}
