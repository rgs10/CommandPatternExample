using System;

namespace CommandPatternExample
{
    public class StopCommand : ICommand
    {
        public string Name
        {
            get { return "Stop"; }
        }
        public void Execute()
        {
            Console.WriteLine("I am executing StopCommand");
        }
    }
}
