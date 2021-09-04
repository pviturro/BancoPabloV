using System;
using System.Collections.Generic;
using System.Text;

namespace BancoPabloV.INTERFACES
{
    interface IAccountable
    {
        public void AddBalance(decimal quantity);
        public void RemoveBalance(decimal quantity);
    }
}
