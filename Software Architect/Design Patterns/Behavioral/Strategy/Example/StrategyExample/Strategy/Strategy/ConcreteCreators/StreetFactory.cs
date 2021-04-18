using Strategy.Creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StreetFactory : SkateFactory
    {
        public override Skate GetSkate()
        {
            return new SkateStreet();
        }
    }
}
