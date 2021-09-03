using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.INTERFACES
{
    interface INotificable
    {
        public string sendNotification(string title, string message);

    }
}
