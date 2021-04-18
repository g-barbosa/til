using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.ConcreteProducts
{
    class SkateVertical : Skate
    {
        public override string type => "Vertical";

        public override decimal price => 350;
    }
}
