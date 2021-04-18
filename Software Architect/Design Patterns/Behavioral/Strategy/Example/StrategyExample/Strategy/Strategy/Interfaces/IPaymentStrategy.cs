using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IPaymentStrategy
    {
        public string Purchase(decimal budget);
    }
}
