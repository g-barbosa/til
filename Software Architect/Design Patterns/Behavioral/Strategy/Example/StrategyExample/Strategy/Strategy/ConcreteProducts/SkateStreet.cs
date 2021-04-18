using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SkateStreet : Skate
    {
        public override string type => "Street";

        public override decimal price => 300;
    }
}
