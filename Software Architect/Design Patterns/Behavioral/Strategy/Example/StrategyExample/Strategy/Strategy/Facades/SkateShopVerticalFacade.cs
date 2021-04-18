using Facade.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SkateShopVerticalFacade : ISkateShopFacade
    {
        private readonly IPayment _payment;

        public SkateShopVerticalFacade(IPayment payment)
        {
            _payment = payment;
        }

        public string Comprar(decimal budget)
        {
            var skateFactory = new VerticalFactory();
            Skate skate = skateFactory.GetSkate();
            return _payment.ValidatePurchase(budget, skate);
        }
    }
}
