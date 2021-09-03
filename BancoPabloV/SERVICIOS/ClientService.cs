using BancoPabloV.CLASES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.SERVICIOS
{
    class ClientService
    {
        public Client Register(string name, string email)
        {
            if (!Validate(email))
                throw new Exception("Email inválido");

            var title = "Bienvenido al banco " + name + "!";
            var message = "Gracias por crear tu cuenta en el banco";
            Notification registerNotification = new Notification(title, message);
            Console.WriteLine(registerNotification.sendNotification(title, message));
            return new Client(name, email);

        }

        public bool Validate(string email)
        {
            if (!email.Contains("@"))
                return false;

            return true;
        }


    }
}
