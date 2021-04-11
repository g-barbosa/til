using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.ExecuteCommand('o');
            Console.ReadKey();
            client.ExecuteCommand('c');
            Console.ReadKey();
            client.ExecuteCommand('l');
            Console.ReadKey();

            client.UndoCommand();
            Console.ReadKey();
            client.UndoCommand();
            Console.ReadKey();
            client.UndoCommand();
            Console.ReadKey();
        }
    }
}
