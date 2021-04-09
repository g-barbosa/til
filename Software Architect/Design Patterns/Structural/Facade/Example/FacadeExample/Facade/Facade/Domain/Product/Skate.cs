using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Domain.Product
{
    public abstract class Skate
    {
        public abstract string type { get; }
        public abstract decimal price { get; }
    }
}
