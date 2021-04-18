using Facade.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SkateShopStreetFacade : ISkateShopFacade
    {
        private readonly IPayment _payment;
        
        public SkateShopStreetFacade(IPayment payment)
        {
            _payment = payment;
        }

        public string Comprar(decimal budget)
        {
            var skateFactory = new StreetFactory();
            Skate skate = skateFactory.GetSkate();
            return _payment.ValidatePurchase(budget, skate);
        }
    }
}
