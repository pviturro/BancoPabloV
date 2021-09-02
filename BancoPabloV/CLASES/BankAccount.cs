﻿using BancoPabloV.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.CLASES
{
    class BankAccount : IAccountable
    {
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string Owner)
        {
            this.Owner = Owner;
        }

        public void BalanceRaise(decimal quantity)
        {
            this.Balance += quantity;
        }

        public void BalanceReduction(decimal quantity)
        {
            if (quantity <= this.Balance)
                this.Balance -= quantity;
            else
                throw new Exception("No tienes suficientes fondos para hacer ese movimiento");
        }
    }
}
