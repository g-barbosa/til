using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SkateShopStreet : IPaymentStrategy
    {
        private readonly ISkateShopFacade _skateShopFacade;
        public SkateShopStreet(ISkateShopFacade skateShopFacade)
        {
            _skateShopFacade = skateShopFacade;
        }
        public string Purchase(decimal budget)
        {
            var status = _skateShopFacade.Comprar(budget);
            return status;
        }
    }
}
