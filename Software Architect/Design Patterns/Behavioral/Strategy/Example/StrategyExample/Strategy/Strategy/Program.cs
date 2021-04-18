using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var streetOrder = new OrderService(SkateShopFactory.DirectToShop(SkateType.Street));
            Console.WriteLine(streetOrder.ValidatePurchase(300));

            var vertOrder = new OrderService(SkateShopFactory.DirectToShop(SkateType.Vertical));
            Console.WriteLine(vertOrder.ValidatePurchase(50));
        }
    }
}
