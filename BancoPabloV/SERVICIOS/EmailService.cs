using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class EmailService
    {
        public string sendEmail(User receiver, Notification notif)
        {
            return $"Para: {receiver.Email} {notif.Title}\n{notif.Message}";
        }

    }
}
