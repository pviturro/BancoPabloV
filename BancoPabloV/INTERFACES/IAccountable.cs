using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.INTERFACES
{
    interface IAccountable
    {
        public void BalanceRaise(decimal quantity);
        public void BalanceReduction(decimal quantity);
    }
}
