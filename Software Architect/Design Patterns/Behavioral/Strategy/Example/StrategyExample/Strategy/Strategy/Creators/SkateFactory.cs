using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Creators
{
    public abstract class SkateFactory
    {
        public abstract Skate GetSkate();
    }
}
