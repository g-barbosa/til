using Facade.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain
{
    public class SkateShopService
    {
        private readonly ISkateShopFacade _skateShopFacade;

        public SkateShopService(ISkateShopFacade skateShopFacade)
        {
            _skateShopFacade = skateShopFacade;
        }

        public string ComprarSkate(string type, decimal budget)
        {
            var status = _skateShopFacade.Comprar(type, budget);
            return status;
        }
    }
}
