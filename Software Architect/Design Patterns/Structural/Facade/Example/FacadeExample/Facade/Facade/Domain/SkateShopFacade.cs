using Facade.Domain.ConcreteCreator;
using Facade.Domain.Creator;
using Facade.Domain.Interface;
using Facade.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain
{
    public class SkateShopFacade : ISkateShopFacade
    {
        private readonly IPayment _payment;
        public SkateShopFacade(IPayment payment)
        {
            _payment = payment;
        }
        public string ComprarSkateStreet(decimal budget)
        {
            var skateFactory = new StreetFactory();
            Skate skate = skateFactory.GetSkate();

            return _payment.ValidatePurchase(budget, skate);
        }

        public string Comprar(string type, decimal budget)
        {
            switch (type.ToLower())
            {
                case "street":
                    return ComprarSkateStreet(budget);
                default:
                    return "Não foi possível realizar esta compra";
            }
        }
    }
}
