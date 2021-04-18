using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface ISkateShopFacade
    {
        string Comprar(decimal budget);
    }
}
