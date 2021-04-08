using FactoryExample.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample.Creator
{
    public abstract class SkateFactory
    {
        public abstract Skate SearchSkate();
    }
}
