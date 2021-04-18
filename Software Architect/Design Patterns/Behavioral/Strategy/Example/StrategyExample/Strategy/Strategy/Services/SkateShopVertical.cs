using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SkateShopVertical : IPaymentStrategy
    {
        private readonly ISkateShopFacade _skateShopFacade;
        public SkateShopVertical(ISkateShopFacade skateShopFacade)
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
