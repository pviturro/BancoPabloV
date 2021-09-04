using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.INTERFACES
{
    public interface INotificable
    {
        public void sendNotification(string title, string message);

    }
}
