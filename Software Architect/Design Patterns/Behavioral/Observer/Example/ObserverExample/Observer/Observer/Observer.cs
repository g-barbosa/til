using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class Observer : IObserver
    {
        public Observer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Notify(DayCounter task)
        {
            Console.WriteLine($"{Name}, estamos a {task.Days} dias sem acidente");
        }
    }
}
