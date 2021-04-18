using Facade.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Payment : IPayment
    {
        public string ValidatePurchase(decimal budget, Skate skate)
        {
            if (budget >= skate.price)
                return "skate comprado com sucesso.";
            return "seu saldo não é suficiente para comprar este skate";
        }
    }
}
