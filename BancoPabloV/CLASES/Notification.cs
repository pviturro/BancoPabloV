﻿using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    class Notification
    {
        public string Title { get; private set; }
        public string Message { get; private set; }

        public Notification (string title, string message)
        {
            this.Title = title;
            this.Message = message;
        }




    }
}
