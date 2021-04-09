using Facade.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain.ConcreteProduct
{
    public class SkateStreet : Skate
    {
        public override string type => "Street";

        public override decimal price => 300;
    }
}
