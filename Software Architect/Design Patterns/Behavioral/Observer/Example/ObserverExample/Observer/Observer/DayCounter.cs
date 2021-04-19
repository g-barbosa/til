using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class DayCounter
    {
        private int _days;
        private readonly List<IObserver> _observers = new List<IObserver>();
        protected DayCounter(int days)
        {
            _days = days;
        }

        public int Days
        {
            get => _days;
            set
            {
                if (_days == value) return;
                _days = value;
                Notify();
            }
        }

        public void Sub(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"{observer.Name} agora recebe atualizações da quantidade de dias sem acidente");
        }

        public void Unsub(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"{observer.Name} deixou de receber atualizações da quantidade de dias sem acidente");
        } 

        private void Notify()
        {
            foreach(var observer in _observers)
            {
                observer.Notify(this);
            }

            Console.WriteLine("");
        }
    }
}
