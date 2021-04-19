using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObserver
    {
        string Name { get; }
        void Notify(DayCounter task);
    }
}
