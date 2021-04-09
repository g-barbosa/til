using Facade.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain.Interface
{
    public interface IPayment
    {
        public string ValidatePurchase(decimal budget, Skate skate);
    }
}
