using System;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            //Execute Start Command
            ICommand command = invoker.GetCommand(ActionType.Start);
            command.Execute();

            //Execute Stop Command
            command = invoker.GetCommand(ActionType.Stop);
            command.Execute();

            Console.WriteLine("Command Pattern Demo");
            Console.Read();
        }

    }
}
