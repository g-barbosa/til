using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SkateShopFactory
    {
        public static IPaymentStrategy DirectToShop(SkateType type)
        {
            switch (type)
            {
                case SkateType.Street:
                    return new SkateShopStreet(new SkateShopStreetFacade(new Payment()));
                case SkateType.Vertical:
                    return new SkateShopVertical(new SkateShopVerticalFacade(new Payment()));
                default:
                    throw new ApplicationException("Não foi possivel encontrar uma loja para este tipo de skate");
            }
        }
    }
}
