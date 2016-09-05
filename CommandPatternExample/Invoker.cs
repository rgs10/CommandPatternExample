namespace CommandPatternExample
{
    public class Invoker
    {
        private ICommand _cmd = null;

        public ICommand GetCommand(ActionType action)
        {
            switch (action)
            {
                case ActionType.Start:
                    _cmd = new StartCommand();
                    break;
                case ActionType.Stop:
                    _cmd = new StopCommand();
                    break;
                default:
                    break;
            }
            return _cmd;
        }
    }

    public enum ActionType
    {
        Start,
        Stop
    }
}
