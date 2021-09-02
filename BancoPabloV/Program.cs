using BancoPabloV.SERVICIOS;
using System;

namespace BancoPabloV
{
    class Program
    {
        static void Main(string[] args)
        {

            NotificationService notifService = new NotificationService();
            notifService.sendNotification("Hola Mundo!", "Hola mundo he dicho leches");


        }
    }
}
