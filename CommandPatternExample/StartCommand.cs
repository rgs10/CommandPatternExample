using System;

namespace CommandPatternExample
{
    public class StartCommand : ICommand
    {
        public string Name
        {
            get
            {
                return "Start";
            }
        }
        public void Execute()
        {
            Console.WriteLine("I am executing StartCommand");
        }
    }
}
