using Facade.Domain.ConcreteProduct;
using Facade.Domain.Creator;
using Facade.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain.ConcreteCreator
{
    public class StreetFactory : SkateFactory
    {
        public override Skate GetSkate()
        {
            return new SkateStreet();
        }
    }
}
