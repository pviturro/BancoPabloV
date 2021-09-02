using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.INTERFACES
{
    interface INotificable
    {
        public string sendSms(string title, string message);

        public string sendEmail(string title, string message);
    }
}
