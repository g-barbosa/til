using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    internal class Door
    {
        private string _currentState;

        public void Action(char act)
        {
            switch (act)
            {
                case 'o': _currentState = "opened"; break;
                case 'c': _currentState = "closed"; break;
                case 'l': _currentState = "locked"; break;
                case 'u': _currentState = "unlocked"; break;
            }

            Console.WriteLine($"The door is currently {_currentState}.");
        }
    }
}
