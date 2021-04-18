using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Skate
    {
        public abstract string type { get; }
        public abstract decimal price { get; }
    }
}
