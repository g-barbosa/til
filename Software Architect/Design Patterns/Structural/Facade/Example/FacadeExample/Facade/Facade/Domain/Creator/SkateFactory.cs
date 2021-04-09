using Facade.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain.Creator
{
    public abstract class SkateFactory
    {
        public abstract Skate GetSkate();
    }
}
