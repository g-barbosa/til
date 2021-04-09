using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain.Interface
{
    public interface ISkateShopFacade
    {
        string ComprarSkateStreet(decimal budget);
        string Comprar(string type, decimal budget);
    }
}
