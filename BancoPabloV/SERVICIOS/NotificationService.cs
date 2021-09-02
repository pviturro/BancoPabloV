using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class NotificationService
    {

        public void sendNotification (string title, string message)
        {
            var notif = new Notification(title, message);
            Console.WriteLine(notif.Title+ " " + notif.Message);
        }

    }
}
