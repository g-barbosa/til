using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class DoorCommand : Commander
    {
        private readonly Door _door;
        private readonly char _act;
        public DoorCommand(Door door, char act)
        {
            _door = door;
            _act = act;
        }

        public override void Execute()
        {
            _door.Action(_act);
        }

        public override void Undo()
        {
            char state = ' ';
            switch (_act)
            {
                case 'c': state = 'o'; break;
                case 'o': state = 'c'; break;
                case 'u': state = 'l'; break;
                case 'l': state = 'u'; break;
                default: throw new ArgumentException("Invalid action");
            }

            _door.Action(state);
        }
    }
}
