using Facade.Domain;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var skateshop = new SkateShopService(new SkateShopFacade(new Payment()));
            Console.WriteLine(skateshop.ComprarSkate("street", 500));
            Console.WriteLine(skateshop.ComprarSkate("street", 299));
        }
    }
}
