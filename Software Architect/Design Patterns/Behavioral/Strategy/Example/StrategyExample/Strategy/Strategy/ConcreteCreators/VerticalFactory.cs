using Strategy.ConcreteProducts;
using Strategy.Creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class VerticalFactory : SkateFactory
    {
        public override Skate GetSkate()
        {
            return new SkateVertical();
        }
    }
}
