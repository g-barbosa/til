using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class Client
    {
        private readonly Door _door = new Door();
        private readonly List<Commander> _commands = new List<Commander>();

        public void ExecuteCommand(char act)
        {
            Commander command = new DoorCommand(_door, act);
            command.Execute();

            _commands.Add(command);
        }

        public void UndoCommand()
        {
            int lastIndex = _commands.Count() - 1;
            Commander command = _commands[lastIndex];
            _commands.RemoveAt(lastIndex);
            command.Undo();
        }
    }
}
