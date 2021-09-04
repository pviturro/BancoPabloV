using BancoPabloV.CLASES;
using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;
using static BancoPabloV.CLASES.Constants;

namespace BancoPabloV.SERVICIOS
{
    class UserService : IRegisterable
    {
        private EmailService emailService = new EmailService();
        public User Register(string name, string email, Usertype usertype)
        {
            if (!Validate(email))
                throw new Exception("Email inválido");

            var title = $"Bienvenido al banco, {name}!";
            var message = "Gracias por crear tu cuenta en el banco";
            Notification registerNotification = new Notification(title, message);
            if (usertype.Equals(Usertype.client))
            {
                var client = new Client(name, email);
                emailService.sendEmail(client, registerNotification);
                return client;
            }
            else if (usertype.Equals(Usertype.employee))
            {
                var employee = new Employee(name, email);
                emailService.sendEmail(employee, registerNotification);
                return employee;
            }
            else
                throw new Exception("Ese tipo de usuario no está registrado");

        }

        public bool Validate(string email)
        {
            if (!email.Contains("@"))
                return false;

            return true;
        }
    }
}
