using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class SmsService
    {
        public string sendSms(User receiver, Notification notification)
        {
            return $"Para: {receiver}. {notification.Title} Mensaje: {notification.Message}";
        }
    }
}
